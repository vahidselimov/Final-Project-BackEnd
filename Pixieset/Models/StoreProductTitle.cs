

using System.Collections.Generic;

namespace Pixieset.Models
{
    public class StoreProductTitle
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public string Description { get; set; }
        public string Text { get; set; }
        public List<StoreProductImage> StoreProductImages { get; set; }


    }
}
