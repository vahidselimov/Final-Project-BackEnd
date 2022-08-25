namespace Pixieset.Models
{
    public class Media
    {
        public int Id { get; set; }
        public string ImagePath { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }=new Category();
    }
}
