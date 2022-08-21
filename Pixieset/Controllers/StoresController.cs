using Microsoft.AspNetCore.Mvc;
using Pixieset.DAL;
using Pixieset.ViewModels;
using System.Linq;

namespace Pixieset.Controllers
{
    public class StoresController : Controller
    {
        private readonly AppDbContext context;

        public StoresController(AppDbContext context)
        {
            this.context = context;
        }
        public IActionResult Store()
        {
            StoreVM storeVM = new StoreVM
            {
                StoreFirst = context.StoreFirsts.FirstOrDefault(),
                StoreCom=context.StoreComs.FirstOrDefault(),
                StoreProductImage=context.StoreProductImages.ToList(),
                StoreProductTitle=context.StoreProductTitle.FirstOrDefault(),
                StoreTools=context.StoreTools.ToList(),
                StoreAutoTitle=context.StoreAutoTitle.FirstOrDefault(),
                StoreAutoSpan=context.StoreAutoSpans.ToList(),
                StoreAutoTexts=context.StoreAutoTexts.ToList(),
                StoreAutoImagesName=context.StoreAutoImagesNames.FirstOrDefault(),
                StoreAutoImages=context.StoreAutoImages.ToList(),
                Get=context.Gets.FirstOrDefault(),
                Cards=context.Cards.ToList(),   


            };
            return View(storeVM);
        }
    }
}
