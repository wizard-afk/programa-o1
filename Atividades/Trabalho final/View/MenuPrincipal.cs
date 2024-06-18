using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
public class MenuPrincipal
{
    private readonly BibliotecarioView _bibliotecarioView;
    private readonly LocatarioView _locatarioView;

    public MenuPrincipal(BibliotecarioView bibliotecarioView, LocatarioView locatarioView)
    {
        _bibliotecarioView = bibliotecarioView;
        _locatarioView = locatarioView;
    }

    public void ExibirMenu()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("=== Sistema de Gestão de Biblioteca ===");
            Console.WriteLine("1. Acessar como Bibliotecário");
            Console.WriteLine("2. Acessar como Locatário");
            Console.WriteLine("0. Sair");
            Console.Write("Escolha uma opção: ");
            string escolha = Console.ReadLine();

            switch (escolha)
            {
                case "1":
                    AcessarComoBibliotecario();
                    break;
                case "2":
                    AcessarComoLocatario();
                    break;
                case "0":
                    return;
                default:
                    Utils.ExibirMensagemErro("Opção inválida.");
                    break;
            }
        }
    }

    private void AcessarComoBibliotecario()
    {
        Console.Write("Digite a senha do Bibliotecário: ");
        string senha = Console.ReadLine();

        if (senha == "adminadmin")
        {
            _bibliotecarioView.ExibirMenuBibliotecario();
        }
        else
        {
            Utils.ExibirMensagemErro("Senha incorreta.");
        }
    }

    private void AcessarComoLocatario()
    {
        _locatarioView.ExibirMenuLocatario();
    }
}
