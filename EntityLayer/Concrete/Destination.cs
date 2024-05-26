using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Destinational
    {
        [Key]
        public int DestinationId { get; set; }
        public string DestinationCity { get; set; }
        public string DestinationDayNight { get; set; }
        public double DestinationPrice { get; set; }
        public string DestinationImg { get; set; }
        public string DestinationDescription { get; set; }
        public string DestinationCapacity { get; set; }
        public bool DestinationStatus { get; set; }
        public string DestinationCoverImg { get; set; }
        public string DestinationCoverImg2 { get; set; }
        public string DestinationDetails1 { get; set; }
        public string DestinationDetails2 { get; set; }
        public List<Comment> Comment { get; set; }
        public List<Reservation> Reservations{ get; set; }
    }
}
