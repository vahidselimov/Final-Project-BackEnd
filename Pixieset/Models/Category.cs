using System.Collections.Generic;

namespace Pixieset.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public List<Media>Media { get; set; }=new List<Media>();
    }
}
