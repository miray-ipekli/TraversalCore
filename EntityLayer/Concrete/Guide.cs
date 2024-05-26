using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Guide
    {
        [Key]
        public int GuideId { get; set; }
        public string GuideName { get; set; }
        public string GuideDescription { get; set; }
        public string GuideImg { get; set; }
        public string GuideTwitterUrl { get; set; }
        public string GuideInstagramUrl { get; set; }
        public bool GuideStatus { get; set; }

    }
}
