using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Biblioteca.Models;
using Biblioteca.Controller;
using Biblioteca.View;
using Biblioteca.Repository;
using Biblioteca.Utils;

namespace Biblioteca.Repository
{
    public class LivroRepository
    {
        private readonly List<Livro> _livros = new List<Livro>();
        private int _nextId = 1;

        public void Add(Livro livro)
        {
            livro.Id = _nextId++;
            _livros.Add(livro);
        }

        public void Update(Livro livro)
        {
            var existingLivro = _livros.FirstOrDefault(l => l.Id == livro.Id);
            if (existingLivro != null)
            {
                existingLivro.Titulo = livro.Titulo;
                existingLivro.Autor = livro.Autor;
                existingLivro.Categoria = livro.Categoria;
                existingLivro.AnoPublicacao = livro.AnoPublicacao;
                existingLivro.Disponivel = livro.Disponivel;
                existingLivro.Biblioteca = livro.Biblioteca;
            }
        }

        public Livro GetById(int id)
        {
            return _livros.FirstOrDefault(l => l.Id == id);
        }

        public List<Livro> GetAll()
        {
            return _livros;
        }

        public void Remove(int id)
        {
            var livro = _livros.FirstOrDefault(l => l.Id == id);
            if (livro != null)
            {
                _livros.Remove(livro);
            }
        }
    }
}