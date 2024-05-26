using BusinessLayer.Concrete;
using DataAccessLayer.EntityFreamework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalCore.Controllers
{
    public class DestinationController : Controller
    {
        DestinationalManager destinationalManager = new DestinationalManager(new EfDestinationalDal());
        private readonly IMemoryCache _memoryCache;

        public DestinationController(IMemoryCache memoryCache)
        {
            _memoryCache = memoryCache;
        }

        public IActionResult Index()
        {
            List<Destinational> values;
            //Önbellekte Destination unique cache key yoksa:
            if (!_memoryCache.TryGetValue("Destination", out values))
            {
                //Destination listesini al.
                values = destinationalManager.TGetList();
                //önbelleğe Destination keyi ile kaydet. 10 dakikalık.
                _memoryCache.Set("Destination", values, TimeSpan.FromMinutes(10));
            }
            //önbellekte yoksa kaydedilip view atıldı.
            //varsa direkt atıldı.

            return View(values);
        }

        [HttpGet]
        public IActionResult DestinationDetails(int id)
        {
            ViewBag.id = id;
            var values = destinationalManager.TGetById(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult DestinationDetails(Destinational p)
        {
            return View();
        }
    }
}
