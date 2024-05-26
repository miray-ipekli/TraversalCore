using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Reservation
    {
        [Key]
        public int ReservationId { get; set; }
        public int AppUserId { get; set; }
        public int DestinationId { get; set; }
        public int PersonCount { get; set; }
        public DateTime ReservationDate { get; set; }
        public string ReservationDescription { get; set; }
        public string ReservationStatus { get; set; }
        public AppUser AppUser { get; set; }
        public Destinational Destination { get; set; }
    }
}
