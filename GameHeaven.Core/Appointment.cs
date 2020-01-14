using System;
using System.Collections.Generic;
using System.Text;

namespace GameHeaven.Core
{
    public class Appointment
    {
        public DateTime Date { get; set; }
        public DateTime Time { get; set; }
        public Team Attendees { get; set; }
        public Game GameToPlay { get; set; }
    }
}
