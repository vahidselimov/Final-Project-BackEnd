using Pixieset.Models;
using System.Collections.Generic;

namespace Pixieset.ViewModels
{
    public class HomeVM
    { 
        public Socialmedias SocialMedias { get; set; }
        public List<SocialIcons>SocialIcons { get; set; }
        public Flow Flow { get; set; }
        public Digital Digital { get; set; }
        public Store Store { get; set; }
        public List <Slider> Sliders { get; set; }
        public  List<Cards> Cards { get; set; }
        public Get Get { get; set; }
        public ProductFirst ProductFirst { get; set; }
    }
}
