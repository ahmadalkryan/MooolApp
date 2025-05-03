using System.ComponentModel.DataAnnotations;

namespace MooolApp.Models
{
    public class Mool:Base
    {   
        [Required(ErrorMessage ="this feild require")]
        public string Name { get; set; }

        public virtual Address Address { get; set; }


        public virtual ICollection<Item>? Items { get; set; }

    }
}
