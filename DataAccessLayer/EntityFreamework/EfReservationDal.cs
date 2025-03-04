﻿using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFreamework
{
    public class EfReservationDal : GenericRepository<Reservation>, IReservationDal
    {
        public List<Reservation> GetListWithReservationByAcceptes(int id)
        {
            using (var context = new Context())
            {
                //Include ile destination id'den adını çekebilmiş olduk.
                return context.Reservations.Include(x => x.Destination).Where(x => x.ReservationStatus == "Onaylandı" && x.AppUserId == id).ToList();
            }
        }

        public List<Reservation> GetListWithReservationByPrevious(int id)
        {
            using (var context = new Context())
            {
                return context.Reservations.Include(x => x.Destination).Where(x => x.ReservationStatus == "Geçmiş Rezervasyon" && x.AppUserId == id).ToList();
            }
        }

        public List<Reservation> GetListWithReservationByWaitApproval(int id)
        {
            using (var context= new Context())
            {
                return context.Reservations.Include(x => x.Destination).Where(x => x.ReservationStatus == "Onay Bekliyor" && x.AppUserId == id).ToList();
            }

        }
    }
}
