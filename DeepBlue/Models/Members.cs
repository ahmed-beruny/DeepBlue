using System.ComponentModel.DataAnnotations;

namespace DeepBlue.Models
{
    public class Members
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public string Password { get; set; }
    }
}
