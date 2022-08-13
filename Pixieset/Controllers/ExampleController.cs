using Microsoft.AspNetCore.Mvc;
using Pixieset.DAL;
using Pixieset.ViewModels;
using System.Linq;

namespace Pixieset.Controllers
{
    public class ExampleController : Controller
    {
        private readonly AppDbContext context;

        public ExampleController(AppDbContext context)
        {
            this.context = context;
        }
        public IActionResult Examples()
        {
            ExampleVM exampleVM = new ExampleVM {

                ExampleFirst = context.ExampleFirsts.FirstOrDefault(),
                ExampleMenus = context.ExampleMenus.ToList(),
                ExampleRows=context.ExamplesRows.ToList(),
                ExampleActions=context.ExampleActions.ToList(),
                ActionsIcons=context.ActionsIcons.ToList(), 
                ExpTitles=context.ExpTitles.FirstOrDefault(),
                Items=context.Item.ToList(),
                Get=context.Gets.FirstOrDefault(),
                Acts=context.Acts.ToList(),
            };

            return View(exampleVM);
        }
    }
}
