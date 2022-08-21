using Pixieset.Models;
using System.Collections.Generic;

namespace Pixieset.ViewModels
{
    public class StoreVM
    {
        public StoreFirst StoreFirst { get; set; }
        public StoreCom StoreCom { get; set; }
        public List<StoreProductImage> StoreProductImage { get; set; }
        public StoreProductTitle StoreProductTitle { get; set; }
        public List<StoreTools> StoreTools { get; set; }
        public StoreAutoTitle StoreAutoTitle { get; set; }
        public List<StoreAutoSpan> StoreAutoSpan { get; set; }
        public List<StoreAutoTexts> StoreAutoTexts { get; set; }
        public StoreAutoImagesName StoreAutoImagesName { get; set; }
        public List<StoreAutoImages>StoreAutoImages { get; set; }
        public Get Get { get; set; }
        public List<Cards> Cards { get; set; }
    }
}
