namespace Pixieset.Models
{
    public class WebsiteIconsTr
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public WebsiteNameTr WebsiteNameTr { get; set; }
        public int? WebsiteNameId { get; set; }
        public WebsiteDomTr WebsiteDomTr { get; set; }
        public int? WebsiteDomId { get; set; }
    }
}
