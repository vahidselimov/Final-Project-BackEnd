using System.Collections.Generic;

namespace Pixieset.Models
{
    public class ExpTitles
    {
        public int  Id { get; set; }
        public string Title { get; set; }
        public List<Item>Items { get; set; }
        public string Descrptions { get; set; }
    }
}
