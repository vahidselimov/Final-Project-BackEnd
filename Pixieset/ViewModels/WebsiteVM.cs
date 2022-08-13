using Pixieset.Models;
using System.Collections.Generic;

namespace Pixieset.ViewModels
{
    public class WebsiteVM
    {
        public WebsiteFirst WebsiteFirst { get; set; }
        public WebSliderTitle WebSliderTitle { get; set; }
        public List<WebSlider>WebSliders { get; set; }
        public WebBuilder WebBuilder { get; set; }
        public List<WebIcons> WebIcons { get; set; }
        public WebTool WebTool { get; set; }
    }
}
