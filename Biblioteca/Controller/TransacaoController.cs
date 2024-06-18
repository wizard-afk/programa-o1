using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Biblioteca.Models;
using Biblioteca.View;
using Biblioteca.Repository;
using Biblioteca.Utils;

namespace Biblioteca.Controller
{
    public class TransacaoController
    {
        private readonly TransacaoRepository _transacaoRepository = new TransacaoRepository();

        public void RegistrarTransacao(Transacao transacao)
        {
            _transacaoRepository.Add(transacao);
        }

        public void AtualizarTransacao(Transacao transacao)
        {
            _transacaoRepository.Update(transacao);
        }

        public Transacao BuscarTransacaoPorId(int id)
        {
            return _transacaoRepository.GetById(id);
        }

        public List<Transacao> ListarTransacoes()
        {
            return _transacaoRepository.GetAll();
        }

        public void RemoverTransacao(int id)
        {
            _transacaoRepository.Remove(id);
        }
    }
}