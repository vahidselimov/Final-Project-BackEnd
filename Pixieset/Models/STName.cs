using System.Collections.Generic;

namespace Pixieset.Models
{
    public class STName
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public List<StText> StText { get; set; }
    }
}
