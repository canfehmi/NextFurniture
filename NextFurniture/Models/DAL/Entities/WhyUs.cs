using System.ComponentModel.DataAnnotations;

namespace NextFurniture.Models.DAL.Entities
{
    public class WhyUs
    {
        [Key]
        public int Id { get; set; }
        public string HeadTitle { get; set; }
        public string ReasonTitle1 { get; set; }
        public string ReasonTitle2 { get; set; }
        public string ReasonTitle3 { get; set; }
        public string ReasonDescription1 { get; set; }
        public string ReasonDescription2 { get; set; }
        public string ReasonDescription3 { get; set; }
    }
}
