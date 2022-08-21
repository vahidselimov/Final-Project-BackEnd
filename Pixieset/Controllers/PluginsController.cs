using Microsoft.AspNetCore.Mvc;
using Pixieset.DAL;
using Pixieset.ViewModels;
using System.Linq;

namespace Pixieset.Controllers
{
    public class PluginsController : Controller
    {
        private readonly AppDbContext context;

        public PluginsController(AppDbContext context)
        {
            this.context = context;
        }
        public IActionResult Plugin()
        {
            PluginsVM pluginsVM = new PluginsVM {
                PluginFirst = context.PluginFirsts.FirstOrDefault(),
                PluginStream=context.PluginStreams.FirstOrDefault(),
                PluginsLight=context.PluginsLights.FirstOrDefault(),
                Get=context.Gets.FirstOrDefault(),

            };

            return View(pluginsVM);
        }
    }
}
