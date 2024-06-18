using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Biblioteca.Models;
using Biblioteca.Controller;
using Biblioteca.View;
using Biblioteca.Repository;
using Biblioteca.Utils;

namespace Biblioteca.Models
{
    public class Livro
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string Categoria { get; set; }
        public int AnoPublicacao { get; set; }
        public bool Disponivel { get; set; } = true;
        public Biblioteca Biblioteca { get; set; }
    }
}