using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Pixieset.Areas.PixiesetAdmin.Models;
using Pixieset.Models;

namespace Pixieset.DAL
{
    public class AppDbContext : IdentityDbContext<AppUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {


        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
        public DbSet<Socialmedias> Socialmedias { get; set; }
        public DbSet<SocialIcons> Socialicons { get; set; }
        public DbSet<Flow> Flows { get; set; }
        public DbSet<Digital> Digital { get; set; }
        public DbSet<Store> Store { get; set; }
        public DbSet<Slider> Slider { get; set; }
        public DbSet<Cards> Cards { get; set; }
        public DbSet<Get> Gets { get; set; }
        public DbSet<ProductFirst> ProductFirst { get; set; }
        public DbSet<ExampleFirst> ExampleFirsts { get; set; }
        public DbSet<ExampleMenu> ExampleMenus { get; set; }
        public DbSet<ExamplesRow> ExamplesRows { get; set; }
        public DbSet<ExampleActions> ExampleActions { get; set; }
        public DbSet<Item> Item { get; set; }
        public DbSet<ExpTitles> ExpTitles { get; set; }
        public DbSet<ActionsIcons> ActionsIcons { get; set; }
        public DbSet<Act> Acts { get; set; }
        public DbSet<PricingFirst> PricingFirst { get; set; }
        public DbSet<PricingMenu> PricingMenus { get; set; }
        public DbSet<TabHeader> TabHeader { get; set; }
        public DbSet<ClientTr> ClientTrs { get; set; }
        public DbSet<StorgeTr> StorgeTrs { get; set; }
        public DbSet<VUploadTr> VUploadTrs { get; set; }
        public DbSet<TrIcons> TrIcons { get; set; }
        public DbSet<TrName> TrNames { get; set; }
        public DbSet<Commission_feeTr> CommissionFeeTrs { get; set; }
        public DbSet<CIcons> CIcons { get; set; }
        public DbSet<Mobileapp> Mobileapp { get; set; }
        public DbSet<CDR> CDRs { get; set; }
        public DbSet<ThBtn> ThBtn { get; set; }
        public DbSet<Cols> Cols { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Pages> Pages { get; set; }
        public DbSet<WebsiteNameTr> WebsitesNames { get; set; }
        public DbSet<WebsiteIconsTr> WebsitesIcons { get; set; }
        public DbSet<WebsiteDomTr> WebsiteDomTr { get; set; }
        public DbSet<STTRcs> STTRcs { get; set; }
        public DbSet<STName> STNames { get; set; }
        public DbSet<StText> StText { get; set; }
        public DbSet<StIcons> StIcons { get; set; }
        public DbSet<SuiteTitle> SuiteTitles { get; set; }
        public DbSet<SuiteImage> SuiteImages { get; set; }
        public DbSet<ClientSuite> ClientSuites { get; set; }
        public DbSet<SuiteCols> SuiteCols { get; set; }
        public DbSet<SuiteStr> SuiteStrs { get; set; }
        public DbSet<SuiteIcons> SuiteIcons { get; set; }
        public DbSet<PricingFrequently> PricingFrequently { get; set; }
        public DbSet<PricingView> PricingViews { get; set; }
        public DbSet<WebsiteFirst> WebsiteFirsts { get; set; }
        public DbSet<WebSliderTitle> WebSliderTitles { get; set; }
        public DbSet<WebBuilder> WebBuilder { get; set; }
        public DbSet<WebSlider> WebSliders { get; set; }
        public DbSet<WebIcons> WebIcons { get; set; }
        public DbSet<WebTool> WebTool { get; set; }
        public DbSet<WebMangTitle> WebMangTitles { get; set; }
        public DbSet<WebManagmentIcons> WebManagmentIcons { get; set; }
        public DbSet<WebProfile> WebProfile { get; set; }
        public DbSet<PluginFirst> PluginFirsts { get; set; }
        public DbSet<PluginStream> PluginStreams { get; set; }
        public DbSet<PluginsLight> PluginsLights { get; set; }
        public DbSet<StoreFirst> StoreFirsts { get; set; }
        public DbSet<StoreCom> StoreComs { get; set; }
        public DbSet<StoreProductImage> StoreProductImages { get; set; }
        public DbSet<StoreProductTitle> StoreProductTitle { get; set; }
        public DbSet<StoreTools> StoreTools { get; set; }
        public DbSet<StoreAutoTitle> StoreAutoTitle { get; set; }
        public DbSet<StoreAutoSpan> StoreAutoSpans { get; set; }
        public DbSet<StoreAutoTexts> StoreAutoTexts { get; set; }
        public DbSet<StoreAutoImages> StoreAutoImages { get; set; }
        public DbSet<StoreAutoImagesName> StoreAutoImagesNames { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Media>Medias { get; set; }
       
    }
}
