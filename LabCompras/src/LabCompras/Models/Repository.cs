using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LabCompras.Models
{
    public static class Repository
    {
        private static List<Despesa> despesas = new List<Despesa>();

        public static List<Despesa> Despesas
        {
            get
            {
                return despesas;
            }
        }

        public static void AddDespesa(Despesa despesa)
        {
            despesas.Add(despesa);
        }

        public static void ClearDespesa()
        {
            despesas.Clear();
        }

        private static List<ContaBancaria> contas = new List<ContaBancaria>();

        public static List<ContaBancaria> Contas
        {
            get
            {
                return contas;
            }
        } 

        public static void AddConta(ContaBancaria conta)
        {
            contas.Add(conta);
        }
        
        public static void ClearConta()
        {
            contas.Clear();
        }               
    }
}
