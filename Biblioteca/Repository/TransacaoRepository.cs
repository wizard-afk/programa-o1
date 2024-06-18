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
    public class TransacaoRepository
    {
        private readonly List<Transacao> _transacoes = new List<Transacao>();
        private int _nextId = 1;

        public void Add(Transacao transacao)
        {
            transacao.Id = _nextId++;
            _transacoes.Add(transacao);
        }

        public void Update(Transacao transacao)
        {
            var existingTransacao = _transacoes.FirstOrDefault(t => t.Id == transacao.Id);
            if (existingTransacao != null)
            {
                existingTransacao.Pessoa = transacao.Pessoa;
                existingTransacao.Livro = transacao.Livro;
                existingTransacao.DataEmprestimo = transacao.DataEmprestimo;
                existingTransacao.DataDevolucao = transacao.DataDevolucao;
                existingTransacao.Multa = transacao.Multa;
            }
        }

        public Transacao GetById(int id)
        {
            return _transacoes.FirstOrDefault(t => t.Id == id);
        }

        public List<Transacao> GetAll()
        {
            return _transacoes;
        }

        public void Remove(int id)
        {
            var transacao = _transacoes.FirstOrDefault(t => t.Id == id);
            if (transacao != null)
            {
                _transacoes.Remove(transacao);
            }
        }
    }
}
