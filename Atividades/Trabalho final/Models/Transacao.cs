using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Models
{
    public class Transacao
    {
        public int Id { get; set; }
        public Pessoa Pessoa { get; set; }
        public Livro Livro { get; set; }
        public DateTime DataEmprestimo { get; set; }
        public DateTime? DataDevolucao { get; set; } // Nullable, pois pode não ter sido devolvido ainda
        public decimal Multa { get; set; } // Calculado se a DataDevolucao for após a DataEmprestimo + período permitido
    }

}