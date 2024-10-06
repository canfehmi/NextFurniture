using System.ComponentModel.DataAnnotations;

namespace NextFurniture.Models.DAL.Entities
{
    public class About
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImgUrl1 { get; set; }
        public string ImgUrl2 { get; set; }
        public string ImgUrl3 { get; set; }
    }
}
