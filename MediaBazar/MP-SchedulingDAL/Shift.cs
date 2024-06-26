using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP_SchedulingDAL
{
    public class Shift
    {
        public int ShiftId { get; set; }
        public User User { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public int State { get; set; }
        //0 - pending
        //1 - accepted
        //2 - denied

        public Shift(int shiftId, User user, DateTime startTime, DateTime endTime, string description, string type, int state)
        {
            this.ShiftId = shiftId;
            this.User = user;
            this.StartTime = startTime;
            this.EndTime = endTime;
            this.Description = description;
            this.Type = type;
            this.State = state;
        }

        public Shift(int id)
        {
            /// <summary>
            /// Unsecure user login, only use without user input, only session and cookie use!
            /// </summary>
            ShiftController shiftController = new ShiftController();
            Shift shiftData = shiftController.GetShiftById(id);

            ShiftId = id;
            User = shiftData.User;
            StartTime = shiftData.StartTime;
            EndTime = shiftData.EndTime;
            Description = shiftData.Description;
            Type = shiftData.Type;
            State = shiftData.State;
        }

        public Shift()
        {
            
        }
    }
}
