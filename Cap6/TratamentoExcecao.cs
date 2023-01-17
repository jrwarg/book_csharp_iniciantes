using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static System.Console;

namespace Cap6
{
    public class TratamentoExcecao
    {
        public static void  ExemploTratamentoExcecao()
        { 
            WriteLine("Divisão de dois números");
            WriteLine("");
            WriteLine("Digite o primeiro número: ");
            var strNum1 = ReadLine();
            WriteLine("Digite o segundo número: ");
            var strNum2 = ReadLine();

            int num1 = int.Parse(strNum1);
            int num2 = int.Parse(strNum2);
            var divisao = num1 / num2;
            WriteLine($"A divisão de {num1} por {num2} é igual a {divisao}");
            WriteLine("Fim");
        }
    }
}