using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace VStorm.Models
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