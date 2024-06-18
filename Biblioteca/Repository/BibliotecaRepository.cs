using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Biblioteca.View;
using Biblioteca.Repository;
using Biblioteca.Utils;
using Biblioteca.Models;
using Biblioteca.Controller;

namespace Biblioteca.Repository
{
    public class BibliotecaRepository
    {
        private readonly List<Models.Biblioteca> _bibliotecas = new List<Models.Biblioteca>();
        private int _nextId = 1;

        public void Add(Models.Biblioteca biblioteca)
        {
            biblioteca.Id = _nextId++;
            _bibliotecas.Add(biblioteca);
        }

        public void Update(Models.Biblioteca biblioteca)
        {
            var existingBiblioteca = _bibliotecas.FirstOrDefault(b => b.Id == biblioteca.Id);
            if (existingBiblioteca != null)
            {
                existingBiblioteca.Nome = biblioteca.Nome;
                existingBiblioteca.Endereco = biblioteca.Endereco;
                existingBiblioteca.Livros = biblioteca.Livros;
            }
        }

        public Models.Biblioteca GetById(int id)
        {
            return _bibliotecas.FirstOrDefault(b => b.Id == id);
        }

        public List<Models.Biblioteca> GetAll()
        {
            return _bibliotecas;
        }

        public void Remove(int id)
        {
            var biblioteca = _bibliotecas.FirstOrDefault(b => b.Id == id);
            if (biblioteca != null)
            {
                _bibliotecas.Remove(biblioteca);
            }
        }
    }
}