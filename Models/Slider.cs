using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GymT110Asp.Models
{
    public class Slider
    {
        public int ID { get; set; }
        [MaxLength(200)]
        public string Header { get; set; }
        public string Description { get; set; }
        public string PhotoUrl { get; set; }
    }
}
