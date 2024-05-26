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
     public class DestinationalManager:IDestinationalService
    {
        IDestinationalDal _destinationalDal;

        public DestinationalManager(IDestinationalDal destinationalDal)
        {
            _destinationalDal = destinationalDal;
        }

        public void TAdd(Destinational t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Destinational t)
        {
            throw new NotImplementedException();
        }

        public Destinational TGetById(int id)
        {
            return _destinationalDal.GetByID(id);
        }

        public List<Destinational> TGetList()
        {
            return _destinationalDal.GetList();
        }

        public void TUpdate(Destinational t)
        {
            throw new NotImplementedException();
        }
    }
}
