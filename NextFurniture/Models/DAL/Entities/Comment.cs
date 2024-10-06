using System.ComponentModel.DataAnnotations;

namespace NextFurniture.Models.DAL.Entities
{
    public class Comment
    {
        [Key]
        public int Id { get; set; }
        public double Star { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string ImgUrl { get; set; }
    }
}
