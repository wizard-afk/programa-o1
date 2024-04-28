using System;
using System.Collections.Generic;
using System.Linq;

namespace Imobiliaria
{
    public class Imovel
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public int NumeroComodos { get; set; }
        public List<string> Imagens { get; set; }
        public Categoria Categoria { get; set; }
        public TipoLocalidade TipoLocalidade { get; set; }
        public TipoNegocio TipoNegocio { get; set; }
    }

    public enum Categoria
    {
        Apartamento,
        Casa,
        Sitio
    }

    public enum TipoLocalidade
    {
        Rural,
        Urbano
    }

    public enum TipoNegocio
    {
        Locacao,
        Venda
    }

    public class ImobiliariaDatabase
    {
        private List<Imovel> imoveis = new List<Imovel>();

        public ImobiliariaDatabase()
        {
            AdicionarImoveisParaTeste();
        }

        private void AdicionarImoveisParaTeste()
        {
            Imovel imovel1 = new Imovel
            {
                Nome = "Apartamento Luxuoso",
                Descricao = "Apartamento de alto padrão com vista para o mar",
                Valor = 1000000,
                NumeroComodos = 4,
                Categoria = Categoria.Apartamento,
                TipoLocalidade = TipoLocalidade.Urbano,
                TipoNegocio = TipoNegocio.Venda,
                Imagens = new List<string> { "imagem1.jpg", "imagem2.jpg" }
            };
            imoveis.Add(imovel1);

            Imovel imovel2 = new Imovel
            {
                Nome = "Casa Familiar",
                Descricao = "Casa espaçosa com jardim e piscina",
                Valor = 500000,
                NumeroComodos = 5,
                Categoria = Categoria.Casa,
                TipoLocalidade = TipoLocalidade.Urbano,
                TipoNegocio = TipoNegocio.Venda,
                Imagens = new List<string> { "imagem3.jpg", "imagem4.jpg" }
            };
            imoveis.Add(imovel2);

            Imovel imovel3 = new Imovel
            {
                Nome = "Sítio Aconchegante",
                Descricao = "Sítio com área verde e espaço para lazer",
                Valor = 300000,
                NumeroComodos = 6,
                Categoria = Categoria.Sitio,
                TipoLocalidade = TipoLocalidade.Rural,
                TipoNegocio = TipoNegocio.Venda,
                Imagens = new List<string> { "imagem5.jpg", "imagem6.jpg" }
            };
            imoveis.Add(imovel3);

            Imovel imovel4 = new Imovel
            {
                Nome = "Apartamento Compacto",
                Descricao = "Apartamento bem localizado em área central",
                Valor = 200000,
                NumeroComodos = 2,
                Categoria = Categoria.Apartamento,
                TipoLocalidade = TipoLocalidade.Urbano,
                TipoNegocio = TipoNegocio.Locacao,
                Imagens = new List<string> { "imagem7.jpg", "imagem8.jpg" }
            };
            imoveis.Add(imovel4);

            Imovel imovel5 = new Imovel
            {
                Nome = "Casa Colonial",
                Descricao = "Casa antiga com arquitetura tradicional",
                Valor = 400000,
                NumeroComodos = 4,
                Categoria = Categoria.Casa,
                TipoLocalidade = TipoLocalidade.Urbano,
                TipoNegocio = TipoNegocio.Venda,
                Imagens = new List<string> { "imagem9.jpg", "imagem10.jpg" }
            };
            imoveis.Add(imovel5);
        }

        public void AdicionarImovel(Imovel imovel)
        {
            imoveis.Add(imovel);
        }

        public List<Imovel> ListarImoveis()
        {
            return imoveis;
        }

        public List<Imovel> ConsultarImoveis(Categoria categoria, TipoLocalidade tipoLocalidade, TipoNegocio tipoNegocio)
        {
            return imoveis.Where(i => i.Categoria == categoria && i.TipoLocalidade == tipoLocalidade && i.TipoNegocio == tipoNegocio).ToList();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ImobiliariaDatabase database = new ImobiliariaDatabase();

            Console.WriteLine("Escolha os filtros para consultar os imóveis:");
            Console.WriteLine("Categoria (1 - Apartamento, 2 - Casa, 3 - Sítio):");
            Categoria categoria = (Categoria)int.Parse(Console.ReadLine());
            Console.WriteLine("Tipo de Localidade (1 - Rural, 2 - Urbano):");
            TipoLocalidade tipoLocalidade = (TipoLocalidade)int.Parse(Console.ReadLine());
            Console.WriteLine("Tipo de Negócio (1 - Locação, 2 - Venda):");
            TipoNegocio tipoNegocio = (TipoNegocio)int.Parse(Console.ReadLine());

            List<Imovel> imoveisFiltrados = database.ConsultarImoveis(categoria, tipoLocalidade, tipoNegocio);

            if (imoveisFiltrados.Count == 0)
            {
                Console.WriteLine("Nenhum imóvel encontrado com os filtros selecionados.");
            }
            else
            {
                Console.WriteLine("Imóveis encontrados:");
                foreach (var imovel in imoveisFiltrados)
                {
                    Console.WriteLine($"Nome: {imovel.Nome}");
                    Console.WriteLine($"Descrição: {imovel.Descricao}");
                    Console.WriteLine($"Valor: {imovel.Valor}");
                    Console.WriteLine($"Número de Cômodos: {imovel.NumeroComodos}");
                    Console.WriteLine($"Categoria: {imovel.Categoria}");
                    Console.WriteLine($"Tipo de Localidade: {imovel.TipoLocalidade}");
                    Console.WriteLine($"Tipo de Negócio: {imovel.TipoNegocio}");
                    Console.WriteLine("Imagens:");
                    foreach (var imagem in imovel.Imagens)  
                    {
                        Console.WriteLine(imagem);
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}

