using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Biblioteca.Models;
using Biblioteca.Controller;
using Biblioteca.View;
using Biblioteca.Repository;
using Biblioteca.Utils;

namespace Biblioteca.Controller
{
    public class LivroController
    {
        private readonly LivroRepository _livroRepository = new LivroRepository();

        public void AdicionarLivro(Livro livro)
        {
            _livroRepository.Add(livro);
        }

        public void AtualizarLivro(Livro livro)
        {
            _livroRepository.Update(livro);
        }

        public Livro BuscarLivroPorId(int id)
        {
            return _livroRepository.GetById(id);
        }

        public List<Livro> ListarLivros()
        {
            return _livroRepository.GetAll();
        }

        public void RemoverLivro(int id)
        {
            _livroRepository.Remove(id);
        }
    }
}