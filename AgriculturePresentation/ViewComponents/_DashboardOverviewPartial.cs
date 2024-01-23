using DataAccessLayer.Contexts;
using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresentation.ViewComponents
{
    public class _DashboardOverviewPartial : ViewComponent
    {
        AgricultureContext c = new AgricultureContext();
        public IViewComponentResult Invoke()
        {
            ViewBag.TeamCount = c.Teams.Count();
            ViewBag.ServiceCount = c.Services.Count();
            ViewBag.MessageCount = c.Contacts.Count();
            ViewBag.currentMonthMessage = 3;

            ViewBag.announcementTrue = c.Announcements.Where(x => x.Status == true).Count();
            ViewBag.announcementFalse = c.Announcements.Where(x => x.Status == false).Count();

            ViewBag.urunPazarlama = c.Teams.Where(x => x.Title == "Ürün Pazarlama").Select(y => y.PersonName).FirstOrDefault();
            ViewBag.sütÜreticisi = c.Teams.Where(x => x.Title == "Süt Üreticisi").Select(y => y.PersonName).FirstOrDefault();
            ViewBag.bakliyatYönetimi = c.Teams.Where(x => x.Title == "Bakliyat Yönetimi").Select(y => y.PersonName).FirstOrDefault();
            ViewBag.gubreYönetimi = c.Teams.Where(x => x.Title == "Gübre Yöneticisi").Select(y => y.PersonName).FirstOrDefault();
            return View();
        }
    }
}
