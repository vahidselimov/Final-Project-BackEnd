using Microsoft.AspNetCore.Mvc;
using Pixieset.DAL;
using Pixieset.ViewModels;
using System.Linq;

namespace Pixieset.Controllers
{
    public class PricingController : Controller
    {
        private readonly AppDbContext context;

        public PricingController(AppDbContext context)
        {
            this.context = context;
        }
        public IActionResult Pricings()
        {
            PricingVM pricingVM = new PricingVM
            {
                PricingFirst = context.PricingFirst.FirstOrDefault(),
                PricingMenu = context.PricingMenus.ToList(),
                TabHeader = context.TabHeader.ToList(),
                ClientTrs = context.ClientTrs.ToList(),
                StorgeTrs = context.StorgeTrs.ToList(),
                VUploadTrs = context.VUploadTrs.ToList(),
                TrIcons = context.TrIcons.ToList(),
                TrName = context.TrNames.ToList(),
                CommissionFeeTrs = context.CommissionFeeTrs.ToList(),
                CIcons = context.CIcons.ToList(),
                Mobileapp = context.Mobileapp.ToList(),
                CDRs = context.CDRs.ToList(),
                ThBtn = context.ThBtn.ToList(),
                Cols = context.Cols.ToList(),
                Clients = context.Clients.ToList(),
                Pages = context.Pages.ToList(),
                WebsiteNames = context.WebsitesNames.ToList(),
                WebsitesIcons = context.WebsitesIcons.ToList(),
                WebsitesDomTrs = context.WebsiteDomTr.ToList(),
                STTRcs = context.STTRcs.ToList(),
                STNames = context.STNames.ToList(),
                StTexts = context.StText.ToList(),
                StIcons = context.StIcons.ToList(),
                SuiteTitle = context.SuiteTitles.FirstOrDefault(),
                SuiteImages = context.SuiteImages.ToList(),
                ClientSuite = context.ClientSuites.ToList(),
                SuiteCols = context.SuiteCols.ToList(),
                SuiteStrs = context.SuiteStrs.ToList(),
                SuiteIcons = context.SuiteIcons.ToList(),
                PricingFrequently = context.PricingFrequently.ToList(),
                PricingView = context.PricingViews.FirstOrDefault(),
                Get = context.Gets.FirstOrDefault(),

            };
            return View(pricingVM);
        }
        public IActionResult PricingStudio()
        {
            PricingVM pricingVM = new PricingVM
            {
                PricingFirst = context.PricingFirst.FirstOrDefault(),
                PricingMenu = context.PricingMenus.ToList(),
                TabHeader = context.TabHeader.ToList(),
                ClientTrs = context.ClientTrs.ToList(),
                StorgeTrs = context.StorgeTrs.ToList(),
                VUploadTrs = context.VUploadTrs.ToList(),
                TrIcons = context.TrIcons.ToList(),
                TrName = context.TrNames.ToList(),
                CommissionFeeTrs = context.CommissionFeeTrs.ToList(),
                CIcons = context.CIcons.ToList(),
                Mobileapp = context.Mobileapp.ToList(),
                CDRs = context.CDRs.ToList(),
                ThBtn = context.ThBtn.ToList(),
                Cols = context.Cols.ToList(),
                Clients = context.Clients.ToList(),
                Pages = context.Pages.ToList(),
                WebsiteNames = context.WebsitesNames.ToList(),
                WebsitesIcons = context.WebsitesIcons.ToList(),
                WebsitesDomTrs = context.WebsiteDomTr.ToList(),
                STTRcs = context.STTRcs.ToList(),
                STNames = context.STNames.ToList(),
                StTexts = context.StText.ToList(),
                StIcons = context.StIcons.ToList(),
                SuiteTitle = context.SuiteTitles.FirstOrDefault(),
                SuiteImages = context.SuiteImages.ToList(),
                ClientSuite = context.ClientSuites.ToList(),
                SuiteCols = context.SuiteCols.ToList(),
                SuiteStrs = context.SuiteStrs.ToList(),
                SuiteIcons = context.SuiteIcons.ToList(),
                PricingFrequently = context.PricingFrequently.ToList(),
                PricingView = context.PricingViews.FirstOrDefault(),
                Get = context.Gets.FirstOrDefault(),

            };
            return View(pricingVM);
        }
        public IActionResult Payment()
        {
            return View();
        }
    }
}
