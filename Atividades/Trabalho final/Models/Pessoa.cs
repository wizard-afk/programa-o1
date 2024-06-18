using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Models
{
    public class Pessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public TipoPessoa Tipo { get; set; } // Enum definido abaixo
    }

    public enum TipoPessoa
    {
        Bibliotecario,
        Locatario
    }

}