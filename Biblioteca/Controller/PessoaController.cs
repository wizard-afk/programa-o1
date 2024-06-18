using System.Collections.Generic;
using Biblioteca.Models;
using Biblioteca.Repository;

namespace Biblioteca.Controller
{
    public class PessoaController
    {
        private readonly PessoaRepository _pessoaRepository;

        public PessoaController(PessoaRepository pessoaRepository)
        {
            _pessoaRepository = pessoaRepository;
        }

        public void AdicionarPessoa(Pessoa pessoa)
        {
            _pessoaRepository.Add(pessoa);
        }

        public void AtualizarPessoa(Pessoa pessoa)
        {
            _pessoaRepository.Update(pessoa);
        }

        public Pessoa BuscarPessoaPorId(int id)
        {
            return _pessoaRepository.GetById(id);
        }

        public List<Pessoa> ListarPessoas()
        {
            return _pessoaRepository.GetAll();
        }

        public void RemoverPessoa(int id)
        {
            _pessoaRepository.Remove(id);
        }
    }
}
