using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GymT110Asp.Models
{
    public class Blog
    {
        public int Id { get; set; }
        public string Header { get; set; }
        public string Description { get; set; }
        public DateTime PublishDate { get; set; }
        public string PhotoUrl { get; set; }
        public int BlogCategoryId { get; set; }
        public virtual BlogCategory BlogCategory { get; set; }
    }

}
