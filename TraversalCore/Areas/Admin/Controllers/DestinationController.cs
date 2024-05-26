using BusinessLayer.Concrete;
using DataAccessLayer.EntityFreamework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalCore.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DestinationController : Controller
    {
        DestinationalManager destinationalManager = new DestinationalManager(new EfDestinationalDal());
        public IActionResult Index()
        {
            var values = destinationalManager.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddDestination()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddDestination(Destinational destination)
        {
            destinationalManager.TAdd(destination);
            return View();
        }

        [HttpGet]
        public IActionResult UpdateDestination(int id)
        {
            var values = destinationalManager.TGetById(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult UpdateDestination(Destinational destination)
        {
            destinationalManager.TUpdate(destination);
            return RedirectToAction("Index");
        }
    }
}
