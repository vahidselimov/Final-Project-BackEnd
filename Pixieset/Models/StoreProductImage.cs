namespace Pixieset.Models
{
    public class StoreProductImage
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string FrontPicture { get; set; }
        public string BackPicture { get; set; }
        public StoreProductTitle Title { get; set; }
    }
}
