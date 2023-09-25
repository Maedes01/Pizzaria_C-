using System;
using System.Collections.Generic;

namespace ProjetoPizzariaNovo
{
    public class PedidoCliente
    {
        public string NomeCliente { get; set; }
        public string NumeroTelefone { get; set; }
    }

    public static class GerenciadorPedidos
    {
        public static List<PedidoCliente> PedidosClientes = new List<PedidoCliente>();

        public static void CriarNovoPedido()
        {
            Console.WriteLine("Registrar um novo pedido:");
            Console.WriteLine("Digite o nome do cliente:");
            var nomeCliente = Console.ReadLine();

            Console.WriteLine("Digite o número de telefone do cliente:");
            var numeroTelefone = Console.ReadLine();

            var pedido = new PedidoCliente
            {
                NomeCliente = nomeCliente,
                NumeroTelefone = numeroTelefone,
            };

            PedidosClientes.Add(pedido);

            Console.WriteLine("Nome do cliente: " + pedido.NomeCliente);
            Console.WriteLine("Número de telefone do cliente: " + pedido.NumeroTelefone);
            Console.WriteLine("Pedido registrado com sucesso!");
        }

        public static void ListarPedidos()
        {
            Console.WriteLine("Pedidos Registrados:");
            foreach (var pedido in PedidosClientes)
            {
                Console.WriteLine("Nome do cliente: " + pedido.NomeCliente);
                Console.WriteLine("Número de telefone do cliente: " + pedido.NumeroTelefone);
            }
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Escolha uma opção:");
                Console.WriteLine("1 - Registrar um novo pedido");
                Console.WriteLine("2 - Listar pedidos registrados");

                var opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        GerenciadorPedidos.CriarNovoPedido();
                        break;
                    case "2":
                        GerenciadorPedidos.ListarPedidos();
                        break;
                }
            }
        }
    }
}
