using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static System.Console;

namespace Cap6
{
    public class TratamentoExcecao
    {
        static void Main(string[] args)
            { 
                WriteLine("Divisão de dois números");
                WriteLine("");
                WriteLine("Digite o primeiro número: ");
                int strNum1 = int.Parse(ReadLine());
                WriteLine("Digite o segundo número: ");
                int strNum2 = int.Parse(ReadLine());
                try
                {
                    int divisao = strNum1 / strNum2;
                    WriteLine($"A divisão de {strNum1} por {strNum2} é igual a {divisao}");
                } catch (DivideByZeroException ex)
                {
                    WriteLine($"Erro de Divisão por Zero: {ex.Message}");
                } catch (FormatException ex)
                {
                    WriteLine($"Erro de Formatação: {ex.Message}");
                } catch (Exception ex)
                {
                    WriteLine($"Erro:  {ex.Message}");
                }
                finally
                {
                    WriteLine("Sempre vai executar o Finally");
                }
                WriteLine("Fim");
            }            
    }
}