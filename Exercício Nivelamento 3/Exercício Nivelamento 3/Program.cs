using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_Nivelamento_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string option;
            int quantidade, codigo;
            string produto;
            double preco, total;
            
            do
            {
                Console.Write("Lancheria do Jeanzinho Krod:\n\n" +
                    "1\tCachorro Quente\t\tR$4,00\n" +
                    "2\tX-Salada\t\tR$4,50\n" +
                    "3\tX-Bacon\t\t\tR$5,00\n" +
                    "4\tTorrada Simples\t\tR$2,00\n" +
                    "5\tRefrigerante\t\tR$1,50");
                
                do
                {
                    Console.Write("\n\nDigite o código do produto: ");
                    codigo = int.Parse(Console.ReadLine());
                    switch (codigo)
                    {
                        case 1:
                            preco = 4.00;
                            produto = "Cachorro Quente";

                            Console.Write("\nSelecione a quantidade de Cachorros Quentes: ");
                            RetornoTotal();
                            break;

                        case 2:
                            preco = 4.50;
                            produto = "X-Salada";

                            Console.Write("\nSelecione a quantidade de X-Saladas: ");
                            RetornoTotal();
                            break;

                        case 3:
                            preco = 5.00; 
                            produto = "X-Bacon";

                            Console.Write("\nSelecione a quantidade de X-Bacons: ");
                            RetornoTotal();
                            break;

                        case 4:
                            preco = 2.00; 
                            produto = "Torrada Simples";

                            Console.Write("\nSelecione a quantidade de Torradas Simples: ");
                            RetornoTotal();
                            break;

                        case 5:
                            preco = 1.50; 
                            produto = "Refrigerante";

                            Console.Write("\nSelecione a quantidade de Refrigerantes: ");
                            RetornoTotal();
                            break;

                        default:
                            Console.Clear();
                            Console.Write("Escolha uma opção válida.\n\n");
                            Console.Write("Lancheria do Jeanzinho Krod:\n\n" +
                                "1\tCachorro Quente\t\tR$4,00\n" +
                                "2\tX-Salada\t\tR$4,50\n" +
                                "3\tX-Bacon\t\t\tR$5,00\n" +
                                "4\tTorrada Simples\t\tR$2,00\n" +
                                "5\tRefrigerante\t\tR$1,50");
                            break;
                    }
                } while (codigo != 1 && codigo != 2 && codigo != 3 && codigo != 4 && codigo != 5);

                Console.Write("\n\nDigite Enter para encerrar o programa," +
                                    " ou digite 1 e tecle Enter para reiniciar... ");
                option = Console.ReadLine();
                Console.Clear();
            }

            while (option == "1");

            void RetornoTotal()
            {
                string confirmarPedido;
                quantidade = int.Parse(Console.ReadLine());
                total = quantidade * preco;
                Console.Write("\nVocê está adquirindo:\n" +
                    "\n\tProduto: " + produto +
                    "\n\tQuantidade: " + quantidade +
                    "\n\tValor a Pagar: R$" + total.ToString("N2"));
                                    
                do
                {                    
                    Console.Write("\n\nDigite 1 e tecle Enter para confirmar o pedido "
                        + "ou digite 0 e tecle Enter para cancelar: ");
                    confirmarPedido = Console.ReadLine();

                    
                if (confirmarPedido == "1")
                    {
                        Console.Write("\nPedido confirmado, obrigado por comprar conosco!");
                    }
                    else if (confirmarPedido == "1")
                    {
                        Console.Write("\nPedido cancelado com sucesso.");
                    }
                    else
                    {
                        Console.Write("\nSelecione uma opção válida.");
                    }
                } while (confirmarPedido != "1" && confirmarPedido != "0");                
            }
        }

    }
}
