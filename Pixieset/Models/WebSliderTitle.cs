using System.Collections.Generic;

namespace Pixieset.Models
{
    public class WebSliderTitle
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public string Description { get; set; }
        public string Title { get; set; }
        public List<WebSlider> WebSliders { get; set; }
    }
}
