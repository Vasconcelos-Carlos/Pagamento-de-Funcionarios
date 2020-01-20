using System;
using Herança_Polimosfismo.course.Entities;
using System.Collections.Generic;

namespace Herança_Polimosfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> ListaFuncionarios = new List<Employee>();


            Console.Write("Quantos funcionarios irão ser cadastrados: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.Write("Outsourced (s/n)?");
                char tipo = char.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Hours: ");
                int horas = int.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double ValorPorHora = double.Parse(Console.ReadLine());
                if (tipo == 's')
                {
                    Console.Write("Additional charge: ");
                    int ValorAdicional = int.Parse(Console.ReadLine());
                    ListaFuncionarios.Add(new OutsourcedEmployee(nome, horas, ValorPorHora, ValorAdicional));

                }
                else
                {
                    ListaFuncionarios.Add(new Employee(nome, horas, ValorPorHora));
                }

            }
            Console.WriteLine("LISTA DE PAGAMENTOS");
            foreach (Employee funcionario in ListaFuncionarios)
            {
                Console.Write($"Nome: {funcionario.Name}, Salário {funcionario.Payment()}");

            }

        }
    }
}
