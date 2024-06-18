using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using Biblioteca.Models;
using Biblioteca.Controller;
using Biblioteca.View;
using Biblioteca.Repository;
using Biblioteca.Utils;

namespace Biblioteca.View
{
    public class MenuPrincipal
    {
        private readonly BibliotecarioView _bibliotecarioView;
        private readonly LocatarioView _locatarioView;

        public MenuPrincipal(BibliotecarioView bibliotecarioView, LocatarioView locatarioView)
        {
            _bibliotecarioView = bibliotecarioView;
            _locatarioView = locatarioView;
        }

        bool sistemaRodando = true;
        public void ExibirMenu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("=== Sistema de Gestão de Biblioteca ===");
                Console.WriteLine("1. Acessar como Bibliotecário");
                Console.WriteLine("2. Acessar como Locatário");
                Console.WriteLine("3. Fechar o Sistema");
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
                    case "3":
                        return;
                    default:
                        Utils.Utils.ExibirMensagemErro("Opção inválida.");
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
                Utils.Utils.ExibirMensagemErro("Senha incorreta.");
            }
        }

        private void AcessarComoLocatario()
        {
            _locatarioView.ExibirMenuLocatario();
        }
    }
}