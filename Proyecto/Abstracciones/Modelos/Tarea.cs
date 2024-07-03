using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Abstracciones.Modelos
{
    public class Tarea
    {
        [Required]
        [RegularExpression(@"^[{]?[0-9a-fA-F]{8}-([0-9a-fA-F]{4}-){3}[0-9a-fA-F]{12}[}]?$")]
        public Guid Id { get; set; }

        [Required]
        [StringLength(6, ErrorMessage = "Debe ser mayor a 4", MinimumLength = 2)]
        [RegularExpression(@"^[a-zA-Z]*$")]
        public string? Nombre { get; set; }

        [Required]
        public string? Descripcion { get; set; }


        [Required]
        [RegularExpression(@"^(?:(?:31(\/|-|\.)(?:0?[13578]|1[02]))\1|(?:(?:29|30)(\/|-|\.)(?:0?[13-9]|1[0-2])\2))(?:(?:1[6-9]|[2-9]\d)?\d{2})$|^(?:29(\/|-|\.)0?2\3(?:(?:(?:1[6-9]|[2-9]\d)? (?:0[48]|[2468][048]|[13579][26])|(?:(?:16|[2468][048]|[3579][26])00))))$|^(?:0?[1 - 9]|1\d|2[0-8])(\/|-|\.)(?:(?:0?[1 - 9])|(?:1[0-2]))\4(?:(?:1[6-9]|[2-9]\d)?\d{2})$")]
        public Date? FechaInicio {  get; set; }

        [Required]
        [RegularExpression(@"^(?:(?:31(\/|-|\.)(?:0?[13578]|1[02]))\1|(?:(?:29|30)(\/|-|\.)(?:0?[13-9]|1[0-2])\2))(?:(?:1[6-9]|[2-9]\d)?\d{2})$|^(?:29(\/|-|\.)0?2\3(?:(?:(?:1[6-9]|[2-9]\d)? (?:0[48]|[2468][048]|[13579][26])|(?:(?:16|[2468][048]|[3579][26])00))))$|^(?:0?[1 - 9]|1\d|2[0-8])(\/|-|\.)(?:(?:0?[1 - 9])|(?:1[0-2]))\4(?:(?:1[6-9]|[2-9]\d)?\d{2})$")]
        public Date? FechaFinal { get; set; }

        [Required]
        [RegularExpression(@"^[{]?[0-9a-fA-F]{8}-([0-9a-fA-F]{4}-){3}[0-9a-fA-F]{12}[}]?$")]
        public Guid Asignado {  get; set; }

        [Required]
        [RegularExpression(@"^[{]?[0-9a-fA-F]{8}-([0-9a-fA-F]{4}-){3}[0-9a-fA-F]{12}[}]?$")]
        public Guid Estado {  get; set; }

        [Required]
        [RegularExpression(@"^[{]?[0-9a-fA-F]{8}-([0-9a-fA-F]{4}-){3}[0-9a-fA-F]{12}[}]?$")]
        public Guid Creador { get; set; }
    }
}
