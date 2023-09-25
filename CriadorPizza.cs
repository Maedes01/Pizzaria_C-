using System;
using System.Collections.Generic;
using System;
using System.Collections.Generic;

namespace ProjetoPizza
{
    public class Pizza
    {
        public string Nome { get; set; }
        public string Sabores { get; set; }
        public decimal Preco { get; set; }
    }

    public static class CriadorPizza
    {
        public static List<Pizza> PizzasCriadas = new List<Pizza>();

        public static void CriarNova()
        {
            Console.WriteLine("Adicionar uma Pizza!");
            Console.WriteLine("Digite o nome da Pizza:");
            var nome = Console.ReadLine();

            Console.WriteLine("Digite os sabores da Pizza separados por vírgula:");
            var sabores = Console.ReadLine();

            Console.WriteLine("Digite o preço da Pizza (formato 00,00):");
            var precoStr = Console.ReadLine();

            if (decimal.TryParse(precoStr, out decimal preco))
            {
                var pizza = new Pizza
                {
                    Nome = nome,
                    Sabores = sabores,
                    Preco = preco
                };

                PizzasCriadas.Add(pizza);

                Console.WriteLine("Nome da pizza: " + pizza.Nome);
                Console.WriteLine("Esses são os sabores da pizza: " + pizza.Sabores);
                Console.WriteLine("Preço da pizza: " + pizza.Preco.ToString("0.00"));
                Console.WriteLine("PIZZA CRIADA COM SUCESSO !!!");
            }
        }

        public static void VisualizarPizzas()
        {
            Console.WriteLine("Pizzas Criadas:");
            foreach (var pizza in PizzasCriadas)
            {
                Console.WriteLine("Nome da pizza: " + pizza.Nome);
                Console.WriteLine("Sabores da pizza : " + pizza.Sabores);
                Console.WriteLine("Preço da pizza: " + pizza.Preco.ToString("0.00"));
            }
        }
    }
}


