using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace LabCompras.Models
{
    public class ContaBancaria
    {
        [Required(ErrorMessage ="É necessário a introdução do nome do titular.")]
        public string NomeTitular { get; set; }

        [Required(ErrorMessage = "É necessário a introdução do saldo da conta.")]
        public int? Saldo { get; set; }

        public bool Ativa { get; set; }

        public ContaBancaria()
        { }
    }
}
