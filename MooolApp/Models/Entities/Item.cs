using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MooolApp.Models
{
    public class Item:Base
    {
        
        public string Name { get; set; }
        [MaxLength(100)]
        
        public string Description { get; set; }

        public double price { get; set; } 

       
        public string? MoolID { get; set; }
        //nav object
        public  virtual Mool? Mool { get; set; }
    }
}
