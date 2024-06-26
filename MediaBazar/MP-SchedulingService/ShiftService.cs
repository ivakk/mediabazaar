using MP_SchedulingDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP_SchedulingService
{
    public class ShiftService
    {
        ShiftController shiftController = new ShiftController();
        public List<Shift> AutoShedule(DateTime start, DateTime end, int departmentId)
        {
            //get all the availability and scheduled shifts for the time period of the department
            List<Shift> shiftList = shiftController.GetShiftsForPeriod(start, end)
                .Where(s => s.User.Department.Id == departmentId).ToList();

            //get all the users within these shifts
            List<User> userList = shiftList.Select(x => x.User).Distinct().ToList();

            //order the shifts by time
            shiftList = shiftList.OrderBy(s => s.StartTime).ToList();
            //removing the duplicates of times to I get all the time slots 
            List<Shift> slots = shiftList
                .GroupBy(s => s.StartTime)
                .Select(z => z.First()).ToList();

            foreach (Shift slot in slots)
            {
                int shiftDemand = 0;
                if (slot.StartTime.Hour == 8)
                    shiftDemand = 1;
                else 
                    shiftDemand = 2;
                List<Shift> shiftsForSlot = shiftList.Where(s => 
                //s.Type == "Availability" && 
                s.StartTime == slot.StartTime &&
                s.EndTime == slot.EndTime).ToList();
                while (shiftDemand > 0)
                {
                    bool emptyCycle = false;
                    User minHoursWorkedUser = new User() { HoursWorked = 100 };
                    //fill in people in this slot until the shilft is full
                    foreach (Shift shift in shiftsForSlot)
                    {
                        //if someone is already sheduled get the shift demand down
                        if(shift.Type == "Shift")
                        {
                            shiftDemand--;
                            shiftsForSlot.Remove(shift);
                            emptyCycle = true;
                            break;
                        }

                        User userOfShift = userList.Where(u => u.Id == shift.User.Id).ToList()[0];

                        //if this shift's user has less hours than the current minimum
                        if (userOfShift.HoursWorked < minHoursWorkedUser.HoursWorked)
                        {
                            minHoursWorkedUser = userOfShift;
                        }
                    }

                    if (!emptyCycle)
                    {
                        //get the shift with the user that has the least hours worked
                        if (minHoursWorkedUser.Id == 0)
                        {
                            //THERE IS NO ENOUGHT AVAILABLE USERS
                            break;
                        }
                        Shift shiftToBeScheduled = shiftsForSlot.Where(s => s.User.Id == minHoursWorkedUser.Id).ToList()[0];


                        //update the selected shift
                        for (int i = 0; i < shiftList.Count; i++)
                        {
                            if (shiftList[i].ShiftId == shiftToBeScheduled.ShiftId)
                            {
                                shiftList[i].State = 1;
                                shiftList[i].Type = "Shift";
                                break;
                            }
                        }

                        //update the user that got a schift
                        for (int i = 0; i < userList.Count; i++)
                        {
                            if (userList[i].Id == minHoursWorkedUser.Id)
                            {
                                userList[i].HoursWorked += 4;
                                break;
                            }
                        }
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
                if (shift.Type == "Shift")
                {
                    shiftController.CreateShift(shift);
                    if(correspondingShift != null && correspondingShift.Type == "Availability")
                        shiftController.DeleteShift(shift.ShiftId);
                }
            }
        }
    }
}
