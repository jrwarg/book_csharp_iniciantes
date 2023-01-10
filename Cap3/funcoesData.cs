using static System.Console;
using System;
using System.Linq;
using System.Globalization;

namespace livrocsharp
{
    public class funcoesData
    {
        static void Main(string[] args)
        {
            int dia = 12;
            int mes = 05;
            int ano = 2021;
            DateTime dtAniversario = new DateTime(ano, mes, dia);
            DateTime dtFesta = new DateTime(2021, 08, 25);
            WriteLine(" ===== Funções de Datas =====");
            WriteLine($"Aniversário : {dtAniversario}");
            WriteLine($"Aniversário: {dtAniversario: dd/MM/yyyy}");
            WriteLine($"Aniversário: {dtAniversario: dddd/MMM/yyyy}");
            WriteLine($"Aniversário: {dtAniversario: dddd dd/MMMM/yyyy}");
            WriteLine(" ");
            WriteLine($"Aniversário: {dtAniversario: yyyy/MM/dd}");
            WriteLine($"Aniversário: {dtAniversario: ddd/MM/yy}");
            WriteLine($"Aniversário: {dtAniversario: dddd dd/MMM MM/yy}");

            DateTime hoje = DateTime.Today;
            WriteLine("TODAY - retorna a data atual");
            WriteLine($"TODAY : {hoje: dd/MM/yyyy}");

            DateTime DataHora = DateTime.Now;
            WriteLine("\nNOW - retorna a data e a hora atuais");
            WriteLine($"Data e hora: {DataHora: dd/MM/yyyy hh:mm:ss}");

            WriteLine("DAY / MONTH / YEAR - Capturar o dia, mês e ao separadamente");
            if (DataHora.Day > 10)
            {
                WriteLine($"Dia: {DataHora.Day}");
            }
            else
            {
                WriteLine($"Dia: 0{DataHora.Day}");
            }
            WriteLine($"Mês: {DataHora.Month}");
            WriteLine($"Ano: {DataHora.Year}");

            DateTime dtPedido = DateTime.Today;
            // adiciona 35 dias
            DateTime dtVencto = dtPedido.AddDays(35);
            // adicionar 2 meses
            DateTime dtPagto = dtVencto.AddMonths(2);
            WriteLine($"Pedido feito em {dtPedido: dd/MMM/yyyy} vence em {dtVencto: dd/MMM/yyyy}");
            WriteLine($"Formatação completa: {dtVencto.ToLongDateString()}");
            WriteLine($"Formatação curta: {dtVencto.ToShortDateString()}");

            // dia da semana:
            WriteLine($"dia da semana: {dtVencto.DayOfWeek}");
            WriteLine($"dia da semana em português: {dtVencto.ToString("dddd", new CultureInfo("pt-BR"))}");
            WriteLine($"Número do dia da semana: {(int)dtVencto.DayOfWeek}");

            // dia do ano
            WriteLine($"dia do ano: {dtVencto.DayOfYear}");

            // subtrai 2 datas
            var qtdeDias = dtPagto.Subtract(dtPedido);
            WriteLine($"Entre o pedido e o pagamento foram {qtdeDias:dd} dias");

            // Conversão de Datas
            WriteLine("Conversão de Texto para Date");
            string dataTexto = "15/07/2021";
            DateTime dataTextoConvertida;
            // tentativa (TryParse) de conversão de dataTexto
            // caso dê certo a saída OUT será em dataTextoConvertida

            if (DateTime.TryParse(dataTexto, out dataTextoConvertida))
            {
                WriteLine("Data com conversão aceita");
            }
            else
            {
                WriteLine("Erro na conversão da data");
            }

            string dataTextoErrada = "15/metade do ano/2021";
            DateTime dataTextoErradaConvertida;
            if (DateTime.TryParse(dataTextoErrada, out dataTextoErradaConvertida))
                WriteLine("Data com conversão aceita");
            else
                WriteLine("Erro na conversão da data");

            // uso de Datas em OBJETOS
            var pedido = new Pedido
            {
                PedidoID = 1,
                DtPedido = DateTime.Today,
                DtPagto = DateTime.Today.AddDays(45),
                Valor = 1500
            };

            WriteLine($"Pedido: {pedido.PedidoID} - " + $"{pedido.DtPedido:dd/MM/yyyy} -" + $"Vencto: {pedido.DtVencimento():dd/MM/yyyy} - " +
            $"Dias Atraso: {pedido.diasAtraso().TotalDays} - " + $"Valor: {pedido.Valor:n2} - " +
            $"Multa: {pedido.multa:n2}");

            // BOXING -> É a conversão de um tipo de valor para o tipo de objeto ou qualquer tipo de interface (está implícito)

            int percentual = 10;
            object objeto1 = percentual;

            // UNBOXING -> O inverso do Boxing. Conversão de um tipo de referência em tipo de valor. Extrai o valor do tipo de referencia e atribui
            // a um tipo de valor. (é explícito, ou seja, precisamos declarar)
            object objeto2 = 10;
            int desconto = (int) objeto2;

            


        }


    }

    public class Pedido

    {
        public int PedidoID { get; set; }
        public DateTime DtPedido { get; set; }
        public DateTime DtVencimento() => DtPedido.AddDays(30);
        public DateTime DtPagto { get; set; }
        public TimeSpan diasAtraso() => DtPagto.Subtract(DtVencimento());
        public decimal Valor { get; set; }
        public decimal multa => Valor * 0.10M;
    }

}


