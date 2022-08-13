using Microsoft.EntityFrameworkCore;
using Pixieset.Models;

namespace Pixieset.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {


        }
        public DbSet<Socialmedias>Socialmedias { get; set; }   
        public DbSet<SocialIcons>Socialicons { get; set; }
        public DbSet<Flow>Flows { get; set; }  
        public DbSet<Digital> Digital { get; set; }
        public DbSet<Store> Store { get; set; } 
        public DbSet<Slider> Slider { get; set; }
        public DbSet<Cards> Cards { get; set; }
        public DbSet<Get> Gets { get; set; }    
        public DbSet<ProductFirst> ProductFirst { get; set; }   
        public DbSet<ExampleFirst>ExampleFirsts { get; set; }
        public DbSet<ExampleMenu> ExampleMenus { get; set; }
        public DbSet<ExamplesRow>ExamplesRows { get; set; } 
      public DbSet<ExampleActions>ExampleActions { get; set; }
       public DbSet<Item> Item { get; set; }
        public DbSet<ExpTitles> ExpTitles { get; set; }
        public DbSet<ActionsIcons>ActionsIcons { get; set; }   
        public DbSet<Act> Acts { get; set; }
        public DbSet<PricingFirst> PricingFirst { get; set; }
        public DbSet<PricingMenu>PricingMenus { get; set; }
        public DbSet<TabHeader> TabHeader { get; set; }
        public DbSet<ClientTr>ClientTrs { get; set; }
        public DbSet<StorgeTr> StorgeTrs { get; set; }
        public DbSet<VUploadTr>VUploadTrs { get; set; }
       public DbSet<TrIcons> TrIcons { get; set; }  
        public DbSet<TrName>TrNames { get; set; }
        public DbSet<Commission_feeTr> CommissionFeeTrs { get; set; }
        public DbSet<CIcons> CIcons{ get; set; }
        public DbSet <Mobileapp> Mobileapp { get; set; }
        public DbSet<CDR>CDRs { get; set; }
        public DbSet<ThBtn> ThBtn { get; set; }
        public DbSet<Cols> Cols { get; set; }
        public DbSet<Client>Clients { get; set; }
        public DbSet<Pages> Pages { get; set; }
        public DbSet<WebsiteNameTr> WebsitesNames { get; set; }
        public DbSet<WebsiteIconsTr> WebsitesIcons { get; set; }
        public DbSet< WebsiteDomTr>  WebsiteDomTr { get; set; }
        public DbSet<STTRcs> STTRcs { get; set; }
        public DbSet<STName>STNames { get; set; }
        public DbSet<StText> StText { get; set; }
        public DbSet<StIcons>StIcons { get; set; }
        public DbSet<SuiteTitle>SuiteTitles { get; set; }
        public DbSet<SuiteImage> SuiteImages { get; set; }
        public DbSet<ClientSuite>ClientSuites { get; set; }
       public DbSet<SuiteCols> SuiteCols { get; set; }
        public DbSet<SuiteStr> SuiteStrs { get; set; }
        public DbSet<SuiteIcons>SuiteIcons { get; set; }
        public DbSet<PricingFrequently> PricingFrequently { get; set; }
        public DbSet<PricingView>PricingViews { get; set; }
        public DbSet<WebsiteFirst> WebsiteFirsts { get; set; }
        public DbSet<WebSliderTitle> WebSliderTitles { get; set; }
        public DbSet<WebBuilder> WebBuilder { get; set; }
        public DbSet<WebSlider>WebSliders { get; set; }
        public DbSet<WebIcons>WebIcons { get; set; }
        public DbSet<WebTool> WebTool { get; set; }
     
        
      

    }
}
