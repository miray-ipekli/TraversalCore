using BusinessLayer.Concrete;
using DataAccessLayer.EntityFreamework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalCore.Areas.Member.Controllers
{
    [Area("Member")]
    public class ReservationController : Controller
    {
        DestinationalManager destinationalManager = new DestinationalManager(new EfDestinationalDal());
        ReservationManager reservationManager = new ReservationManager(new EfReservationDal());

        //Giriş yapan kullanıcı bilgisi
        private readonly UserManager<AppUser> _userManager;

        public ReservationController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IActionResult> MyCurrentReservation()
        {
            //Aktif kullanıcının adına göre nesneyi getir
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            //Id'ye göre metodu uygula. Sonuçları listeye ata.
            var valuesList = reservationManager.GetListWithReservationByAcceptes(values.Id);
            return View(valuesList);
        }

        public async Task<IActionResult> MyOldReservation()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            var valuesList = reservationManager.GetListWithReservationByPrevious(values.Id);
            return View(valuesList);
        }

        public async Task<IActionResult> MyApprovalReservation()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            var valuesList= reservationManager.GetListWithReservationByWaitApproval(values.Id);
            return View(valuesList);
        }

        [HttpGet]
        public IActionResult NewReservation()
        {
            //DropDown List içini doldurduk.
            List<SelectListItem> values = (from x in destinationalManager.TGetList()
                                           select new SelectListItem
                                           {
                                               Text = x.DestinationCity,
                                               Value = x.DestinationId.ToString()
                                           }).ToList();
            ViewBag.v = values;
            return View();
        } 

        [HttpPost]
        public async Task<IActionResult> NewReservation(Reservation p)
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            p.AppUserId = values.Id;
            p.ReservationStatus = "Onay Bekliyor";
            reservationManager.TAdd(p);
            return RedirectToAction("MyCurrentReservation", "Reservation");
        }
    }
}
