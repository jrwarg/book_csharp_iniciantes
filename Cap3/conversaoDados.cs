using static System.Console;
using System;
using System.Linq;
using System.Globalization;

namespace livrocsharp
{
    class conversaoDados
    {
        static void Main(string[] args)
        {
            // boxing (converte um tipo para Object)
            WriteLine("==== BOXING ====");
            int percentual = 10;
            object objPercentual = percentual;
            WriteLine($"percentual: {percentual} - {percentual.GetType()}");
            WriteLine($"objPercentual: {objPercentual} - {objPercentual.GetType()}");

            decimal salario = 12500.50M;
            object objSalario = salario;
            WriteLine($"salario: {salario} - {salario.GetType()}");
            WriteLine($"objSalario: {objSalario} - {objSalario.GetType()}");

            // boxing de tipos texto (string) e data ( DateTime )
            string nome = "Visual C#";
            object objNome = nome;
            WriteLine($"nome: {nome} - {nome.GetType()}");
            WriteLine($"objNome: {objNome} - {objNome.GetType()}");

            DateTime hoje = DateTime.Today;
            object objHoje = hoje;
            WriteLine($"hoje: {hoje} - {hoje.GetType()}");
            WriteLine($"objHoje: {objHoje} - {objHoje.GetType()}");

            // UNBoxing (converte um objeto para um tipo)
            object objDesconto = 10;
            int desconto = (int)objDesconto;
            WriteLine($"====UNBOXING====");
            WriteLine($"desconto: {desconto} - {desconto.GetType()}");
            WriteLine($"objDesconto: {objDesconto} - {objDesconto.GetType()}");

            try
            {
                // Conversões com PARSE
                WriteLine("====PARSE====");
                WriteLine($"{Int16.Parse("150")}");

                // os parenteses representam o valor negativo:
                WriteLine($"{Int16.Parse("(150)", NumberStyles.AllowParentheses)}");

                // retornar 50000 mesmo com o ponto de milhar
                WriteLine($"{int.Parse("50.000", NumberStyles.AllowThousands)}");

                // retorna 50000 mesmo com o símbolo monetário:
                WriteLine($"Cultura atual: {CultureInfo.CurrentCulture.Name}");
                WriteLine($"Símbolo da Moeda: {NumberFormatInfo.CurrentInfo.CurrencySymbol}");
                WriteLine($"{int.Parse("R$50000", NumberStyles.AllowCurrencySymbol)}");

                // retorna -200 com o símbolo de negativo (-)
                WriteLine($"{int.Parse("-200", NumberStyles.AllowLeadingSign)}");
                // retornar 200 mesmo com os espaços em branco anstes e depois
                WriteLine($"{int.Parse(" 100 ", NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite)}");

                // retorna 5432123456
                WriteLine($"{Int64.Parse("5432123456")}");

                WriteLine($"Data: {DateTime.Parse("21/4/2021"):dd/MMM/yyyy}");
            }
            catch (Exception e)
            {
                WriteLine(e);
            }

            try
            {
                // Conversões com Convert.To
                WriteLine("====Convert Números====");
                int n1 = Convert.ToInt16("100");
                WriteLine($"{n1.GetType()} - {n1}");
                Int32 n2 = Convert.ToInt32("200500");
                WriteLine($"{n2.GetType()} - {n2}");
                Int64 n3 = Convert.ToInt64("100323213132321");
                WriteLine($"{n3.GetType()} - {n3}");
                decimal preco = Convert.ToDecimal("1420,50");
                WriteLine($"{preco.GetType()} - {preco:n2}");

                WriteLine($"====Convert String====");
                string texto1 = Convert.ToString(250.59M);
                WriteLine($"{texto1.GetType()} - {texto1} - resultado: {texto1 ?? "texto é nulo"}");

                string texto2 = Convert.ToString(DateTime.Today);
                WriteLine($"{texto2.GetType()} - {texto2}");

                WriteLine("==== Convert Boleano====");
                bool valido = Convert.ToBoolean("false");
                WriteLine($"{valido.GetType()} - {valido}");
                WriteLine($"0 - {Convert.ToBoolean(0)}");
                WriteLine($"1 - {Convert.ToBoolean(1)}");
                WriteLine($"100 - {Convert.ToBoolean(100)}");

                WriteLine("====Convert Data====");
                DateTime natal = Convert.ToDateTime("25/12/2021");
                WriteLine($"Natal: {natal.GetType()} - {natal:dd/MMMM/yyyy}");
                WriteLine($"Natal: {natal.Day} - {natal.Month} - {natal.Year}");
            }
            catch (Exception e)
            {
                WriteLine(e);
            }
        }
    }
}