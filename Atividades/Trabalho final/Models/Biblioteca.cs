using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class Biblioteca
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Endereco { get; set; }
    public List<Livro> Livros { get; set; } = new List<Livro>();
}
