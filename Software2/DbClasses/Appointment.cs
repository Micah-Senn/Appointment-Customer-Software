using System;
using System.Collections.Generic;
using System.Text;

namespace Software2
{
    public class Appointment
    {
        public int appointmentId { get; set; }
        public string customerId { get; set; }
        public string userId { get; set; }
        public string description { get; set; }
        public string type { get; set; }
        public DateTime start { get; set; }
        public DateTime end { get; set; }

        public Appointment(string customerId, string userId, string description, string type, DateTime start, DateTime end)
        {
            this.customerId = customerId;
            this.userId = userId;
            this.description = description;
            this.type = type;
            this.start = start;
            this.end = end;
        }

    }
}
