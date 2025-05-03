using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MooolApp.Models
{
    public class Address:Base
    {  
       
        public string street { get; set; }
       
        public string city { get; set; }

        
    }
}
