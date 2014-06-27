using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VStorm.Models.ContactsModel
{
    
    [Table("Contacts")]
    public class ContactItem
    {
        public int Id { get; set; }                     

        [Required, StringLength(maximumLength: 30)]
        public string Description { get; set; }
        [Required]
        public string Value { get; set; }
    }
}