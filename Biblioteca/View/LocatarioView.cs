using System;
using System.Collections.Generic;
using System.Linq;
using Biblioteca.Models;
using Biblioteca.Controller;
using Biblioteca.Repository;
using Biblioteca.Utils;

namespace Biblioteca.View
{
    public class LocatarioView
    {
        private readonly LivroController _livroController;
        private readonly TransacaoController _transacaoController;
        private readonly PessoaController _pessoaController;

        public LocatarioView(LivroController livroController, TransacaoController transacaoController, PessoaController pessoaController)
        {
            _livroController = livroController;
            _transacaoController = transacaoController;
            _pessoaController = pessoaController;
        }

        public void ExibirMenuLocatario()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("=== Menu do Locatário ===");
                Console.WriteLine("1. Listar Livros Disponíveis");
                Console.WriteLine("2. Alugar Livro");
                Console.WriteLine("3. Verificar Livros Alugados");
                Console.WriteLine("0. Voltar");
                Console.Write("Escolha uma opção: ");
                string escolha = Console.ReadLine();

                switch (escolha)
                {
                    case "1":
                        ListarLivrosDisponiveis();
                        break;
                    case "2":
                        AlugarLivro();
                        break;
                    case "3":
                        VerificarLivrosAlugados();
                        break;
                    case "0":
                        return;
                    default:
                        Utils.Utils.ExibirMensagemErro("Opção inválida.");
                        break;
                }
            }
        }

        private void ListarLivrosDisponiveis()
        {
            Console.Clear();
            Console.WriteLine("=== Livros Disponíveis ===");
            List<Livro> livros = _livroController.ListarLivros()
                .Where(l => l.Disponivel)
                .ToList();

            foreach (var livro in livros)
            {
                Console.WriteLine($"ID: {livro.Id}, Título: {livro.Titulo}, Autor: {livro.Autor}, Categoria: {livro.Categoria}, Ano: {livro.AnoPublicacao}");
            }
            Utils.Utils.ExibirMensagem("Fim da lista.");
        }

        private void AlugarLivro()
        {
            Console.Clear();
            Console.WriteLine("=== Alugar Livro ===");
            int idLivro = Utils.Utils.LerInteiro("ID do Livro: ");
            Livro livro = _livroController.BuscarLivroPorId(idLivro);

            if (livro == null || !livro.Disponivel)
            {
                Utils.Utils.ExibirMensagemErro("Livro não disponível.");
                return;
            }

            int idLocatario = Utils.Utils.LerInteiro("ID do Locatário: ");
            Pessoa locatario = _pessoaController.BuscarPessoaPorId(idLocatario);

            if (locatario == null || locatario.Tipo != TipoPessoa.Locatario)
            {
                Utils.Utils.ExibirMensagemErro("Locatário não encontrado ou não autorizado.");
                return;
            }

            Transacao transacao = new Transacao
            {
                Pessoa = locatario,
                Livro = livro,
                DataEmprestimo = DateTime.Now,
                DataDevolucao = null,
                Multa = 0
            };

            livro.Disponivel = false;
            _livroController.AtualizarLivro(livro);
            _transacaoController.RegistrarTransacao(transacao);

            Utils.Utils.ExibirMensagem("Livro alugado com sucesso.");
        }

        private void VerificarLivrosAlugados()
        {
            Console.Clear();
            Console.WriteLine("=== Livros Alugados ===");
            int idLocatario = Utils.Utils.LerInteiro("ID do Locatário: ");
            Pessoa locatario = _pessoaController.BuscarPessoaPorId(idLocatario);

            if (locatario == null || locatario.Tipo != TipoPessoa.Locatario)
            {
                Utils.Utils.ExibirMensagemErro("Locatário não encontrado ou não autorizado.");
                return;
            }

            List<Transacao> transacoes = _transacaoController.ListarTransacoes()
                .Where(t => t.Pessoa.Id == idLocatario && t.DataDevolucao == null)
                .ToList();

            foreach (var transacao in transacoes)
            {
                Livro livro = transacao.Livro;
                TimeSpan atraso = DateTime.Now - transacao.DataEmprestimo.AddDays(30); // Supondo um período de empréstimo de 30 dias
                decimal multa = atraso.Days > 0 ? atraso.Days * 0.50m : 0m; // Supondo multa de 0.50 por dia de atraso

                Console.WriteLine($"ID: {livro.Id}, Título: {livro.Titulo}, Autor: {livro.Autor}, Categoria: {livro.Categoria}, Ano: {livro.AnoPublicacao}, Data de Empréstimo: {transacao.DataEmprestimo}, Multa: {multa:C}");
            }
            Utils.Utils.ExibirMensagem("Fim da lista.");
        }
    }
}
