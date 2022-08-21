using Microsoft.AspNetCore.Mvc;
using Pixieset.DAL;
using Pixieset.ViewModels;
using System.Linq;

namespace Pixieset.Controllers
{
    public class WebsiteController : Controller
    {
        private readonly AppDbContext context;

        public WebsiteController(AppDbContext context)
        {
            this.context = context;
        }
        public IActionResult Websites()
        {
            WebsiteVM websiteVM = new WebsiteVM
            {
                WebsiteFirst =context.WebsiteFirsts.FirstOrDefault(),
                WebSliders=context.WebSliders.ToList(),
                WebSliderTitle=context.WebSliderTitles.FirstOrDefault(),
                WebBuilder=context.WebBuilder.FirstOrDefault(),
                WebIcons=context.WebIcons.ToList(),
                WebTool=context.WebTool.FirstOrDefault(),
                WebManagmentIcons=context.WebManagmentIcons.ToList(),
                WebMangTitle=context.WebMangTitles.FirstOrDefault(),
                WebProfile=context.WebProfile.FirstOrDefault(),
                Cards=context.Cards.ToList(),
                Get=context.Gets.FirstOrDefault(),
            };
            return View(websiteVM);
        }
    }
}
