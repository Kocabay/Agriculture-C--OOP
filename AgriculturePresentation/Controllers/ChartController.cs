using AgriculturePresentation.Models;
using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresentation.Controllers
{
    public class ChartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ProductChart()
        {
            List<ProductClass> productclass = new List<ProductClass>();
            productclass.Add(new ProductClass
            {
                productname = "Buğday",
                productvalue = 850
            });
            productclass.Add(new ProductClass
            {
                productname = "Mercimek",
                productvalue = 480
            });
            productclass.Add(new ProductClass
            {
                productname = "Arpa",
                productvalue = 250
            });
            productclass.Add(new ProductClass
            {
                productname = "Pirinç",
                productvalue = 120
            });
            productclass.Add(new ProductClass
            {
                productname = "Domates",
                productvalue = 960
            });


            return Json(new { jsonlist = productclass });
        }
    }
}
