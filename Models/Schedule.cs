using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GymT110Asp.Models
{
    public class Schedule
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string GymDay { get; set; }
        public string Trainer { get; set; }
        public int WeekDaysId { get; set; }
        public virtual WeekDay WeekDays { get; set; }
    }
}
