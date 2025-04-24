using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MyCollection.web.Models
{
    public class Artist
    {
        public int Id { get; set; }
        [DisplayName("First Name")]
        public string FirstName { get; set; }
        [DisplayName("Last Name")]
        [Required]
        public string LastName { get; set; }
    }
}
