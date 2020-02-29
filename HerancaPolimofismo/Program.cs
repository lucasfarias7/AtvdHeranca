using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HerancaPolimofismo.Entities;
using System.Globalization;

namespace HerancaPolimofismo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Produto> listProd = new List<Produto>();


            Console.WriteLine("Informe o numero de produtos: ");
            int n = int.Parse(Console.ReadLine());

            for(int i=1; i<=n; i++)
            {
                Console.WriteLine("Produto #"+i);
                Console.Write("O produto é: Comum, importado ou Usado? ");
                string tipo = Console.ReadLine();

                if(tipo == "Comum" || tipo == "comum")
                {
                    Console.Write("Nome do produto: ");
                    string nome = Console.ReadLine();
                    Console.Write("Preco do produto: ");
                    double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Produto prod = new Produto(nome, preco);

                    listProd.Add(prod);
                }
                else if(tipo == "Importado" || tipo == "importado")
                {
                    Console.Write("Nome do produto: ");
                    string nome = Console.ReadLine();
                    Console.Write("Preco do produto: ");
                    double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Preço da alfandega: ");
                    double precoAlf = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Produto prod = new ProdutoImportado(nome, preco, precoAlf);

                    listProd.Add(prod);
                    
                }
                else
                {
                    Console.Write("Nome do produto: ");
                    string nome = Console.ReadLine();
                    Console.Write("Preco do produto: ");
                    double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Data de fabricação: ");
                    DateTime datafabr = DateTime.Parse(Console.ReadLine());

                    Produto prod = new ProdutoUsado(nome, preco, datafabr);

                    listProd.Add(prod);


                }
            }

            Console.WriteLine();
            Console.WriteLine("Lista de produtos: ");
            foreach(Produto produto in listProd)
            {
                Console.WriteLine(produto.EtiquetaPreco());
            }
        }
    }
}
