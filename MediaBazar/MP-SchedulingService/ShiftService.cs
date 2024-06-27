using MP_SchedulingDAL;

public class ShiftService
{
    ShiftController shiftController = new ShiftController();

    public List<Shift> AutoShedule(DateTime start, DateTime end, int departmentId)
    {
        // Get all the availability and scheduled shifts for the time period of the department
        List<Shift> shiftList = shiftController.GetShiftsForPeriod(start, end)
            .Where(s => s.User.Department.Id == departmentId).ToList();

        // Get all the users within these shifts
        List<User> userList = shiftList.Select(x => x.User).Distinct().ToList();

        // Order the shifts by time
        shiftList = shiftList.OrderBy(s => s.StartTime).ToList();

        // Removing the duplicates of times to get all the time slots 
        List<Shift> slots = shiftList
            .GroupBy(s => s.StartTime)
            .Select(z => z.First()).ToList();

        foreach (Shift slot in slots)
        {
            int shiftDemand = slot.StartTime.Hour == 8 ? 1 : 2;
            List<Shift> shiftsForSlot = shiftList.Where(s =>
                s.StartTime == slot.StartTime &&
                s.EndTime == slot.EndTime).ToList();

            while (shiftDemand > 0)
            {
                bool emptyCycle = false;
                User minHoursWorkedUser = new User() { HoursWorked = 100 };

                foreach (Shift shift in shiftsForSlot.ToList())
                {
                    // If someone is already scheduled, reduce the shift demand
                    if (shift.State == 1)
                    {
                        shiftDemand--;
                        shiftsForSlot.Remove(shift);
                        emptyCycle = true;
                        break;
                    }

                    User userOfShift = userList.FirstOrDefault(u => u.Id == shift.User.Id);

                    // Check if the user has reached the maximum shifts for the day
                    if (shiftController.HasReachedMaxShiftsForDay(shift.User.Id, slot.StartTime))
                    {
                        shiftsForSlot.Remove(shift);
                        continue;
                    }

                    // If this shift's user has less hours than the current minimum
                    if (userOfShift != null && userOfShift.HoursWorked < minHoursWorkedUser.HoursWorked)
                    {
                        minHoursWorkedUser = userOfShift;
                    }
                }

                if (!emptyCycle)
                {
                    // Get the shift with the user that has the least hours worked
                    if (minHoursWorkedUser.Id == 0)
                    {
                        // There are not enough available users
                        break;
                    }

                    Shift shiftToBeScheduled = shiftsForSlot.FirstOrDefault(s => s.User.Id == minHoursWorkedUser.Id);

                    // Ensure the shift is adjacent to an existing shift for this user
                    if (shiftToBeScheduled == null || !shiftController.IsShiftAllowed(shiftToBeScheduled))
                    {
                        shiftsForSlot.Remove(shiftToBeScheduled);
                        continue;
                    }

                    // Update the selected shift
                    for (int i = 0; i < shiftList.Count; i++)
                    {
                        if (shiftList[i].ShiftId == shiftToBeScheduled.ShiftId)
                        {
                            shiftList[i].State = 1;
                            break;
                        }
                    }

                    // Update the user that got a shift
                    for (int i = 0; i < userList.Count; i++)
                    {
                        if (userList[i].Id == minHoursWorkedUser.Id)
                        {
                            userList[i].HoursWorked += 4;
                            break;
                        }
                    }

                    shiftDemand--;
                }
            }
        }
        return shiftList;
    }

    public void SaveAutoScheduling(DateTime start, DateTime end, List<Shift> shifts)
    {
        List<Shift> currentShifts = shiftController.GetShiftsForPeriod(start, end);
        foreach (Shift shift in shifts)
        {
            Shift correspondingShift = currentShifts.Find(s => s.ShiftId == shift.ShiftId);
            if (shift.State == 1)
            {
                shiftController.UpdateShiftStatus(shift.ShiftId, 1);
            }
        }
    }
}
