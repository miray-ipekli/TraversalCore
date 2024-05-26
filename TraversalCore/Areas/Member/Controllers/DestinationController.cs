using BusinessLayer.Concrete;
using DataAccessLayer.EntityFreamework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalCore.Areas.Member.Controllers
{
    [AllowAnonymous]
    [Area("Member")]
    public class DestinationController : Controller
    {
        DestinationalManager destinationalManager = new DestinationalManager(new EfDestinationalDal());
        public IActionResult Index()
        {
            var values = destinationalManager.TGetList();
            return View(values);
        }
    }
}
