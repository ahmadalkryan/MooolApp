using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MooolApp.Models
{
    public class Item:Base
    {
        [Required(ErrorMessage = "this feild require")]
        public string Name { get; set; }
        [MaxLength(100)]
        [Required(ErrorMessage = "this feild require")]
        public string Description { get; set; }

        public double price { get; set; } 

        [ForeignKey("Mool")]
        public string MoolID { get; set; }
        //nav object
        public  virtual Mool? _Mool { get; set; }
    }
}
