using Pixieset.Models;
using System.Collections.Generic;

namespace Pixieset.ViewModels
{
    public class PricingVM
    {
        public PricingFirst PricingFirst { get; set; }
        public List<PricingMenu> PricingMenu { get; set; }
        public List<PricingMenu> PricingMenus { get; set; }
        public List<TabHeader> TabHeader { get; set; }
        public List<ClientTr> ClientTrs { get; set; }
        public List<StorgeTr> StorgeTrs { get; set; }
        public List<VUploadTr> VUploadTrs { get; set; }
        public List<TrName> TrName { get; set; }
        public List<TrIcons> TrIcons { get; set; }
        public List<Commission_feeTr> CommissionFeeTrs { get; set; }
        public List<CIcons> CIcons { get; set; }
        public List<Mobileapp> Mobileapp { get; set; }
        public List<CDR>CDRs { get; set; }
        public List<ThBtn> ThBtn { get; set; }
        public List<Cols> Cols { get; set; }
        public List<Client>Clients { get; set; }
        public List<Pages> Pages { get; set; }
        public List<WebsiteIconsTr> WebsitesIcons { get; set; }
        public List<WebsiteNameTr>WebsiteNames { get; set; }
      public List<WebsiteDomTr> WebsitesDomTrs { get; set; }    
        public List<STTRcs> STTRcs { get; set; }
        public List<STName> STNames  { get; set; }
        public List<StText>StTexts { get; set; }
        public List<StIcons>StIcons { get; set; }
        public SuiteTitle SuiteTitle { get; set; }
        public List<SuiteImage>SuiteImages { get; set; }
        public List<ClientSuite> ClientSuite { get; set; }
        public List<SuiteCols> SuiteCols { get; set; }
        public List<SuiteStr> SuiteStrs { get; set; }
        public List<SuiteIcons> SuiteIcons { get; set; }
        public List<PricingFrequently> PricingFrequently { get; set; }
        public PricingView PricingView { get; set; }
        public Get Get { get; set; }

    }
}
