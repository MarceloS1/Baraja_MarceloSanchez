using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace NaipesWeb.Models
{
    public class Naipe
    {
      
  	[Key]
    public string NaipeId { get; set; }
    [Required(AllowEmptyStrings = false, ErrorMessage = "{0} es requerido")]
    public string Nombre { get; set; }
    [Required(AllowEmptyStrings = false, ErrorMessage = "{0} es requerido")]

    [Url]
    public string Imagen { get; set; }

}
}
