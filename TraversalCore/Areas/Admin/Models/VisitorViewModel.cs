using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalCore.Areas.Admin.Models
{
    public class VisitorViewModel
    {
        [Key]
        public int VisitorId { get; set; }
        public string VisitorName { get; set; }
        public string VisitorSurname { get; set; }
        public string VisitorCity { get; set; }
        public string VisitorCountry { get; set; }
        public string VisitorMail { get; set; }
    }
}
