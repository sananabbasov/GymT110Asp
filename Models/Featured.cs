using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GymT110Asp.Models
{
    public class Featured
    {
        public int Id { get; set; }
        public string PhotoUrl { get; set; }
        public DateTime PublishDate { get; set; }
        public string Author { get; set; }
        public string Name { get; set; }
    }
}
