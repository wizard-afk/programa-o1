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
    public class BibliotecaController
    {
        private readonly BibliotecaRepository _bibliotecaRepository = new BibliotecaRepository();

        public void AdicionarBiblioteca(Models.Biblioteca biblioteca)
        {
            _bibliotecaRepository.Add(biblioteca);
        }

        public void AtualizarBiblioteca(Models.Biblioteca biblioteca)
        {
            _bibliotecaRepository.Update(biblioteca);
        }

        public Models.Biblioteca BuscarBibliotecaPorId(int id)
        {
            return _bibliotecaRepository.GetById(id);
        }

        public List<Models.Biblioteca> ListarBibliotecas()
        {
            return _bibliotecaRepository.GetAll();
        }

        public void RemoverBiblioteca(int id)
        {
            _bibliotecaRepository.Remove(id);
        }
    }
}