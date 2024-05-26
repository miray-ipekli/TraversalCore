using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Testimonial
    {
        [Key]
        public int TestimonialId { get; set; }
        public string TestimonialClient { get; set; }
        public string TestimonialComment { get; set; }
        public string TestimonialClientImg { get; set; }
        public bool TestimonialStatus { get; set; }
    }
}
