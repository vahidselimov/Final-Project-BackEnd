using Microsoft.AspNetCore.Mvc;
using Pixieset.DAL;
using Pixieset.Models;
using Pixieset.ViewModels;
using System.Linq;
using System.Threading.Tasks;

namespace Pixieset.Controllers
{
    
    public class HomeController : Controller
    {
        private readonly AppDbContext context;

        public HomeController(AppDbContext context)
        {
            this.context = context;
        }
        public IActionResult Products()
        {
            HomeVM homeVM = new HomeVM
            {
                SocialMedias = context.Socialmedias.FirstOrDefault(),
                SocialIcons=context.Socialicons.ToList(),
                Flow=context.Flows.FirstOrDefault(),
                Digital=context.Digital.FirstOrDefault(),   
                Store=context.Store.FirstOrDefault(),
                Sliders=context.Slider.ToList(),
                Cards=context.Cards.ToList(),   
                Get=context.Gets.FirstOrDefault(),  
                ProductFirst=context.ProductFirst.FirstOrDefault(), 

                
            };
            return View(homeVM); 
        }

    }
}
