using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using Biblioteca.Controller;
using Biblioteca.View;
using Biblioteca.Repository;
using Biblioteca.Utils;
using Biblioteca.Models;

namespace Biblioteca
{
    class Program
    {
        static void Main(string[] args)
        {
            // Inicializa repositórios
            LivroRepository livroRepository = new LivroRepository();
            PessoaRepository pessoaRepository = new PessoaRepository();
            TransacaoRepository transacaoRepository = new TransacaoRepository();

            // Adiciona livros iniciais
            List<Models.Livro> livrosIniciais = new List<Livro>
            {
                new Livro { Id = 1, Titulo = "Dom Casmurro", Autor = "Machado de Assis", Categoria = "Romance", AnoPublicacao = 1899, Disponivel = true },
                new Livro { Id = 2, Titulo = "O Alienista", Autor = "Machado de Assis", Categoria = "Romance", AnoPublicacao = 1882, Disponivel = true },
                new Livro { Id = 3, Titulo = "O Hobbit", Autor = "J.R.R. Tolkien", Categoria = "Fantasia", AnoPublicacao = 1937, Disponivel = true },
                // Adicione mais livros conforme necessário
            };
            foreach (var livro in livrosIniciais)
            {
                livroRepository.Add(livro);
            }

            // Adiciona usuários iniciais
            List<Pessoa> pessoasIniciais = new List<Pessoa>
            {
                new Pessoa { Id = 1, Nome = "Bibliotecário Chefe", Tipo = TipoPessoa.Bibliotecario },
                new Pessoa { Id = 2, Nome = "Locatário João", Tipo = TipoPessoa.Locatario },
                // Adicione mais usuários conforme necessário
            };
            foreach (var pessoa in pessoasIniciais)
            {
                pessoaRepository.Add(pessoa);
            }

            // Inicializa controllers e views
            LivroController livroController = new LivroController();
            PessoaController pessoaController = new PessoaController(pessoaRepository);
            TransacaoController transacaoController = new TransacaoController();

            BibliotecarioView bibliotecarioView = new BibliotecarioView(livroController, transacaoController, pessoaController);
            LocatarioView locatarioView = new LocatarioView(livroController, transacaoController, pessoaController);

            MenuPrincipal menuPrincipal = new MenuPrincipal(bibliotecarioView, locatarioView);
            menuPrincipal.ExibirMenu();
        }
    }
}

