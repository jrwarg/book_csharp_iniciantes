using System;
using System.Collections.Generic;

namespace ExemploArrays
{
    public class ExemploClasseArray
    {
        static void Main()
        {   
            // ====COLEÇÕES==== //

            // Declarando uma array e já atribuindo valores:
            int[] segundArray = new int[] {1, 3, 5, 7, 9};

            // Console.Write("Valor da array na posição 0 -> {0}  ", segundArray[0]);
            Console.Write($"Valor na posição 0 da array: {segundArray[0]}");

            // ==== LISTAS ==== //

            List<string> nomesFuncionarios = new List<string>();
            nomesFuncionarios.Add("Maria");
            nomesFuncionarios.Add("João");
            nomesFuncionarios.Add("André");
            nomesFuncionarios.Add("Flávia");

            Console.WriteLine();
            foreach( string pessoa in nomesFuncionarios)
            { 
                Console.WriteLine(pessoa);
            }

            Console.WriteLine();
            // Removendo Maria da Lista de funcionários:
            nomesFuncionarios.RemoveAt(0);
            Console.WriteLine(nomesFuncionarios[0]);

            // Lista de tipo Genéricos

        }
    }
}