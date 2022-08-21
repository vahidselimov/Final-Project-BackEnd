using Pixieset.Models;
using System.Collections.Generic;

namespace Pixieset.ViewModels
{
    public class WebsiteVM
    {
        public WebsiteFirst WebsiteFirst { get; set; }
        public WebSliderTitle WebSliderTitle { get; set; }
        public List<WebSlider> WebSliders { get; set; }
        public WebBuilder WebBuilder { get; set; }
        public List<WebIcons> WebIcons { get; set; }
        public WebTool WebTool { get; set; }
        public List<WebManagmentIcons> WebManagmentIcons { get; set; }
        public WebMangTitle WebMangTitle { get; set; }
        public WebProfile WebProfile { get; set; }
        public List<Cards> Cards { get; set; }
        public Get Get { get; set; }  
     
        
    }
}
