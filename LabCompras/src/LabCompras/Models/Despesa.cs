using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace LabCompras.Models
{
    public class Despesa
    {
        [Required(ErrorMessage ="É necessário introduzir o nome da despesa.")]
        public string NomeDespesa { get; set; }

        public int Quantidade { get; set; }

        [Required(ErrorMessage ="É necessário introduzir o valor da despesa.")]
        public double? Valor { get; set; }

        [Required(ErrorMessage ="É necessário introduzir a categoria da despesa.")]
        public string Categoria { get; set; }

        public bool Pago { get; set; }

        public Despesa()
        { }
    }
}
