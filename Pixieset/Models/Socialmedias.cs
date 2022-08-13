using System.Collections.Generic;

namespace Pixieset.Models
{
    public class Socialmedias
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public string Right { get; set; }
        public string Image { get; set; }
        public string Span1 { get; set; }
        public string Span2 { get; set; }
        public string Span3 { get; set; }
        public string Icon1 { get; set; }
        public string Icon2 { get; set; }
     public List<SocialIcons> SocialIcons { get; set; }

        
    }
}
