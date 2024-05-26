using BusinessLayer.Concrete;
using DataAccessLayer.EntityFreamework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalCore.ViewComponents.Default
{
    public class _PopularDestinationsPartial:ViewComponent
    {
        DestinationalManager destinationalManager = new DestinationalManager(new EfDestinationalDal());
        public IViewComponentResult Invoke()
        {
            var values = destinationalManager.TGetList();
            return View(values);
        }
    }
}
