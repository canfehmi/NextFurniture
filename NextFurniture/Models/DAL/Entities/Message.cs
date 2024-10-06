using System.ComponentModel.DataAnnotations;

namespace NextFurniture.Models.DAL.Entities
{
    public class Message
    {
        [Key]
        public int Id { get; set; }
        public string NameSurname { get; set; }
        public string Mail { get; set; }
        public string Subject { get; set; }
        public string FullMessage { get; set; }
        public DateTime Date { get; set; }
    }
}
