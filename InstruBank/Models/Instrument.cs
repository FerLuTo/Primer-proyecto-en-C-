using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using InstruBank.Validator;
using System.ComponentModel.DataAnnotations.Schema;

namespace InstruBank.Models
{
    public class Instrument
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Campo obligatorio")]
        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "Campo obligatorio")]
        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        public string Tipo { get; set; }
        [Required(ErrorMessage = "Campo obligatorio")]
        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        public string Marca { get; set; }
        [Required(ErrorMessage = "Campo obligatorio")]
        [Column(TypeName = "decimal(18,2)")]
        [CheckPrice]
        public decimal Precio { get; set; }
        [Required(ErrorMessage = "Campo obligatorio")]
        public int Stock { get; set; }
    }
}
