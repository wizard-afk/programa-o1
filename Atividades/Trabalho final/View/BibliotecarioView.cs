using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
public class BibliotecarioView
{
    private readonly LivroController _livroController;
    private readonly TransacaoController _transacaoController;

    public BibliotecarioView(LivroController livroController, TransacaoController transacaoController)
    {
        _livroController = livroController;
        _transacaoController = transacaoController;
    }

    public void ExibirMenuBibliotecario()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("=== Menu do Bibliotecário ===");
            Console.WriteLine("1. Adicionar Livro");
            Console.WriteLine("2. Atualizar Livro");
            Console.WriteLine("3. Remover Livro");
            Console.WriteLine("4. Listar Todos os Livros");
            Console.WriteLine("5. Listar Livros Alugados");
            Console.WriteLine("6. Listar Livros Disponíveis");
            Console.WriteLine("0. Voltar");
            Console.Write("Escolha uma opção: ");
            string escolha = Console.ReadLine();

            switch (escolha)
            {
                case "1":
                    AdicionarLivro();
                    break;
                case "2":
                    AtualizarLivro();
                    break;
                case "3":
                    RemoverLivro();
                    break;
                case "4":
                    ListarTodosLivros();
                    break;
                case "5":
                    ListarLivrosAlugados();
                    break;
                case "6":
                    ListarLivrosDisponiveis();
                    break;
                case "0":
                    return;
                default:
                    Utils.ExibirMensagemErro("Opção inválida.");
                    break;
            }
        }
    }

    private void AdicionarLivro()
    {
        Console.Clear();
        Console.WriteLine("=== Adicionar Livro ===");
        Console.Write("Título: ");
        string titulo = Console.ReadLine();
        Console.Write("Autor: ");
        string autor = Console.ReadLine();
        Console.Write("Categoria: ");
        string categoria = Console.ReadLine();
        int anoPublicacao = Utils.LerInteiro("Ano de Publicação: ");
        
        Livro livro = new Livro
        {
            Titulo = titulo,
            Autor = autor,
            Categoria = categoria,
            AnoPublicacao = anoPublicacao,
            Disponivel = true
        };

        _livroController.AdicionarLivro(livro);
        Utils.ExibirMensagem("Livro adicionado com sucesso.");
    }

    private void AtualizarLivro()
    {
        Console.Clear();
        Console.WriteLine("=== Atualizar Livro ===");
        int id = Utils.LerInteiro("ID do Livro: ");
        
        Livro livro = _livroController.BuscarLivroPorId(id);
        if (livro == null)
        {
            Utils.ExibirMensagemErro("Livro não encontrado.");
            return;
        }

        Console.Write($"Título ({livro.Titulo}): ");
        string titulo = Console.ReadLine();
        Console.Write($"Autor ({livro.Autor}): ");
        string autor = Console.ReadLine();
        Console.Write($"Categoria ({livro.Categoria}): ");
        string categoria = Console.ReadLine();
        Console.Write($"Ano de Publicação ({livro.AnoPublicacao}): ");
        string anoPublicacao = Console.ReadLine();

        livro.Titulo = string.IsNullOrEmpty(titulo) ? livro.Titulo : titulo;
        livro.Autor = string.IsNullOrEmpty(autor) ? livro.Autor : autor;
        livro.Categoria = string.IsNullOrEmpty(categoria) ? livro.Categoria : categoria;
        livro.AnoPublicacao = string.IsNullOrEmpty(anoPublicacao) ? livro.AnoPublicacao : int.Parse(anoPublicacao);

        _livroController.AtualizarLivro(livro);
        Utils.ExibirMensagem("Livro atualizado com sucesso.");
    }

    private void RemoverLivro()
    {
        Console.Clear();
        Console.WriteLine("=== Remover Livro ===");
        int id = Utils.LerInteiro("ID do Livro: ");

        _livroController.RemoverLivro(id);
        Utils.ExibirMensagem("Livro removido com sucesso.");
    }

    private void ListarTodosLivros()
    {
        Console.Clear();
        Console.WriteLine("=== Todos os Livros ===");
        List<Livro> livros = _livroController.ListarLivros();

        foreach (var livro in livros)
        {
            Console.WriteLine($"ID: {livro.Id}, Título: {livro.Titulo}, Autor: {livro.Autor}, Categoria: {livro.Categoria}, Ano: {livro.AnoPublicacao}, Disponível: {livro.Disponivel}");
        }
        Utils.ExibirMensagem("Fim da lista.");
    }

    private void ListarLivrosAlugados()
    {
        Console.Clear();
        Console.WriteLine("=== Livros Alugados ===");
        List<Transacao> transacoes = _transacaoController.ListarTransacoes()
            .Where(t => t.DataDevolucao == null)
            .ToList();

        foreach (var transacao in transacoes)
        {
            Livro livro = transacao.Livro;
            TimeSpan atraso = DateTime.Now - transacao.DataEmprestimo.AddDays(30); // Supondo um período de empréstimo de 30 dias
            decimal multa = atraso.Days > 0 ? atraso.Days * 0.50m : 0m; // Supondo multa de 0.50 por dia de atraso

            Console.WriteLine($"ID: {livro.Id}, Título: {livro.Titulo}, Autor: {livro.Autor}, Categoria: {livro.Categoria}, Ano: {livro.AnoPublicacao}, Data de Empréstimo: {transacao.DataEmprestimo}, Multa: {multa:C}");
        }
        Utils.ExibirMensagem("Fim da lista.");
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
        Utils.ExibirMensagem("Fim da lista.");
    }
}
