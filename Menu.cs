using System;
using System.Collections.Generic;

using System;
using System.Collections.Generic;

namespace ProjetoPizza
{
    public class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Escolha uma opção:");
                Console.WriteLine("1 - Criar uma nova pizza");
                Console.WriteLine("2 - Visualizar pizzas criadas");
                Console.WriteLine("3 - Criar Novo pedido ");
                Console.WriteLine("4 - Listar pedidos");

                var opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        CriadorPizza.CriarNova();
                        break;
                    case "2":
                        CriadorPizza.VisualizarPizzas();
                        break;
                    case "3":
                        Criadorpedidos.CriarNovos();
                        break;
                    case "4":
                        Criadorpedidos.VisualizarPedidos();
                        break;
                }
            }
        }
    }
}



