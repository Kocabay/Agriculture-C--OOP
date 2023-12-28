using BusinessLayer.Abstract;
using DataAccessLayer.Contexts;
using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresentation.ViewComponents
{
    public class _AboutPartial :ViewComponent

    {
        private readonly IAboutService _aboutService;

        public _AboutPartial(IAboutService aboutService)
        {
            _aboutService = aboutService;
        }

        public IViewComponentResult Invoke()
        {
             AgricultureContext c = new AgricultureContext();
            var values = c.Abouts.ToList();
            return View( values);
        }
    }
}
