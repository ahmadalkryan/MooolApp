using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MooolApp.Models
{
    public class Base
    {  [Key]
     [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id  { get; set; }
    }
}
