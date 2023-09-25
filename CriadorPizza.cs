using System;
using System.Collections.Generic;

namespace ProjetoPizzaria
{
    public class ReceitaPizza
    {
        public string Tipo { get; set; }
        public string Ingredientes { get; set; }
        public decimal Valor { get; set; }
    }

    public static class Pizzaria
    {
        public static List<ReceitaPizza> Receitas = new List<ReceitaPizza>();

        public static void CriarReceita()
        {
            Console.WriteLine("Criar uma nova receita de pizza:");
            Console.WriteLine("Digite o tipo de pizza:");
            var tipo = Console.ReadLine();

            Console.WriteLine("Digite os ingredientes da pizza separados por vírgula:");
            var ingredientes = Console.ReadLine();

            Console.WriteLine("Digite o valor da pizza (formato 00,00):");
            var valorStr = Console.ReadLine();

            if (decimal.TryParse(valorStr, out decimal valor))
            {
                var receita = new ReceitaPizza
                {
                    Tipo = tipo,
                    Ingredientes = ingredientes,
                    Valor = valor
                };

                Receitas.Add(receita);

                Console.WriteLine("Tipo de pizza: " + receita.Tipo);
                Console.WriteLine("Ingredientes: " + receita.Ingredientes);
                Console.WriteLine("Valor da pizza: " + receita.Valor.ToString("0.00"));
                Console.WriteLine("Receita de pizza criada com sucesso!");
            }
        }

        public static void VerReceitas()
        {
            Console.WriteLine("Receitas de Pizza Criadas:");
            foreach (var receita in Receitas)
            {
                Console.WriteLine("Tipo de pizza: " + receita.Tipo);
                Console.WriteLine("Ingredientes: " + receita.Ingredientes);
                Console.WriteLine("Valor da pizza: " + receita.Valor.ToString("0.00"));
            }
        }
    }
}



