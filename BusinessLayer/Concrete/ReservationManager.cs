using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ReservationManager : IReservationService
    {
        IReservationDal _resevationDal;

        public ReservationManager(IReservationDal resevationDal)
        {
            _resevationDal = resevationDal;
        }

        public List<Reservation> GetListWithReservationByAcceptes(int id)
        {
            return _resevationDal.GetListWithReservationByAcceptes(id);
        }

        public List<Reservation> GetListWithReservationByPrevious(int id)
        {
            return _resevationDal.GetListWithReservationByPrevious(id);
        }

        public List<Reservation> GetListWithReservationByWaitApproval(int id)
        {
            return _resevationDal.GetListWithReservationByWaitApproval(id);
        }

        public void TAdd(Reservation t)
        {
            _resevationDal.Insert(t);
        }

        public void TDelete(Reservation t)
        {
            throw new NotImplementedException();
        }

        public Reservation TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Reservation> TGetList()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Reservation t)
        {
            throw new NotImplementedException();
        }
    }
}
