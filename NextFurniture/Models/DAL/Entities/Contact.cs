using System.ComponentModel.DataAnnotations;

namespace NextFurniture.Models.DAL.Entities
{
    public class Contact
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
