using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MooolApp.Models
{
    public class Address:Base
    {  
        [Required]
        public string street { get; set; }
        [Required]
        public string city { get; set; }

        [ForeignKey("Moll")]
        public string MoolId { get; set; }

        public virtual Mool ?_mool { get; set; }

    }
}
