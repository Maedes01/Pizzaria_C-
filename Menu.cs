 using System;
using System.Collections.Generic;

using System;
using System.Collections.Generic;

 public class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Escolha uma opção:");
                Console.WriteLine("1 - Criar um novo pedido de pizza");
                Console.WriteLine("2 - Listar pedidos realizados");

                var opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        PizzariaApp.CriarPedido();
                        break;
                    case "2":
                        PizzariaApp.ListarPedidos();
                        break;
                }
            }
        }
    }

