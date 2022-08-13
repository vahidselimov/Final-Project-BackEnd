using System.Collections.Generic;

namespace Pixieset.Models
{
    public class TrName
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public List<TrIcons> TrIcons { get; set; }
       
        public string Name { get; set; }
    }
}
