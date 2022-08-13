namespace Pixieset.Models
{
    public class TrIcons
    {
        public int Id { get; set; }
        public string IconsName { get; set; }
        public TrName TrName { get; set; }
        public CIcons CIcons { get; set; }
        public int? CIconsId { get; set; }
        public int TrId { get; set; }
        public CDR CDR { get; set; }
        public int? CDRId { get; set; }
    }
}
