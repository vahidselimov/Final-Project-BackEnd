using System.Collections.Generic;

namespace Pixieset.Models
{
    public class CDR
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Text { get; set; }
        public List<TrIcons> TrIcons { get; set; }

    }
}
