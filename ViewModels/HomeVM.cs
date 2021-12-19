using GymT110Asp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GymT110Asp.ViewModels
{
    public class HomeVM
    {
        public List<Slider> Sliders { get; set; }
        public List<Product> Products { get; set; }
        public AboutLeft AboutLeft { get; set; }
        public List<AboutRight> AboutRights { get; set; }
        public List<Featured> Featureds { get; set; }
        public List<Schedule> Schedules { get; set; }
    }
}
