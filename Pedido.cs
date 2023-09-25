using System.Dynamic;

namespace ProjetoPizza{
    public class Pedidos
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }
    
    }
    public static class Criadorpedidos
    {
        public static List<Pedidos> Pedidoscriados = new List<Pedidos>();

        public static void CriarNovos()
        {
            Console.WriteLine("Quem é o cliente ? ");
            var nome = Console.ReadLine();

            Console.WriteLine("Qual é o telefone do cliente? ");
            var telefone = Console.ReadLine();


            var pedido = new Pedidos
                {
                    Nome = nome,
                    Telefone = telefone,
                };

                Pedidoscriados.Add(pedido);

                Console.WriteLine("Nome do cliente: " + pedido.Nome);
                Console.WriteLine("Esse é o telefone do cliente: " + pedido.Telefone);
                }
                public static void VisualizarPedidos()
                {
                    Console.WriteLine("Pedidos Criados:");
                    foreach (var pedido in Pedidoscriados)
                    {
                    Console.WriteLine("Nome do cliente: " + pedido.Nome);
                    Console.WriteLine("Telefone do cliente: " + pedido.Telefone);
                    }
                }
}
}
   