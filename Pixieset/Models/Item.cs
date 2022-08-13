namespace Pixieset.Models
{
    public class Item
    {
        public int Id { get; set; }

        public string Image { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public ExpTitles ExpTitles { get; set; }    
        public int? ExpTitlesId { get; set; }
    }
}
