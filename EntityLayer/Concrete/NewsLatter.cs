using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class NewsLatter
    {
        [Key]
        public int NewsLatterId { get; set; }
        public string NewsLatterMail { get; set; }
    }
}
