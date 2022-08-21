using System.Collections.Generic;

namespace Pixieset.Models
{
    public class WebMangTitle
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public List<WebManagmentIcons> WebManagmentIcons { get; set; }

    }

}
