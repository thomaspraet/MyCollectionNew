using System.ComponentModel.DataAnnotations;

namespace MyCollection.web.Models
{
    public class Artist
    {
        public int Id { get; set; }

        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
    }
}
