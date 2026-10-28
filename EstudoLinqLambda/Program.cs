using System;
using System.Collections.Generic;
using System.Linq; // Namespace obrigatório para usar LINQ
using EstudoLinqLambda.Models;

namespace EstudoLinqLambda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Aula 03: Expressões Lambda e LINQ ===\n");

            // --- PARTE 1: Transformação simples com Lambda ---
            var numeros = new[] { 1, 2, 3, 4, 5 };
            
            // Usando lambda inline (x => x * x) para calcular o quadrado de cada número
            var quadrados = Array.ConvertAll(numeros, x => x * x);

            Console.Write("Números originais: ");
            Console.WriteLine(string.Join(", ", numeros));

            Console.Write("Quadrados (via Lambda): ");
            Console.WriteLine(string.Join(", ", quadrados));
            Console.WriteLine("\n--------------------------------------------------\n");

            // --- PARTE 2: Consultas Avançadas com LINQ sobre Objetos ---
            List<Produto> produtos = new List<Produto>
            {
                new Produto { Nome = "Monitor Gamer", Preco = 1200.00 },
                new Produto { Nome = "Mouse Pad", Preco = 45.00 },
                new Produto { Nome = "Teclado Mecânico", Preco = 250.00 },
                new Produto { Nome = "Cabo HDMI", Preco = 30.00 },
                new Produto { Nome = "Mesa Digitalizadora", Preco = 650.00 }
            };

            // Filtragem combinada: Preço > R$ 100,00 E Nome que inicia com 'M'
            // Ordenados ascendentemente por Nome usando .OrderBy()
            var produtosFiltrados = produtos
                .Where(p => p.Preco > 100.00 && p.Nome.StartsWith("M"))
                .OrderBy(p => p.Nome);

            Console.WriteLine("Produtos Filtrados (> R$ 100,00 e iniciados com 'M') - Ordenados por Nome:");
            foreach (var p in produtosFiltrados)
            {
                Console.WriteLine($"-> {p.Nome}: {p.Preco:C2}");
            }

            // Ordenação decrescente por preço usando .OrderByDescending()
            var produtosPorPrecoDecrescente = produtos
                .OrderByDescending(p => p.Preco);

            Console.WriteLine("\nTodos os produtos ordenados por Preço (Decrescente):");
            foreach (var p in produtosPorPrecoDecrescente)
            {
                Console.WriteLine($"-> {p.Nome}: {p.Preco:C2}");
            }
        }
    }
}