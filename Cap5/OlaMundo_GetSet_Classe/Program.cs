using System;
using MinhaClasseUsuario;

namespace MinhaPrimeiraClasse
{
    class ProgramaPrincipal
    {
        static void Main(string[] args)
        {
            // Criamos o objeto Pedido herdado da classe InteracaoUsuario
            InteracaoUsuario Pedido = new InteracaoUsuario();
            // Invocamos os metodos do objeto Pedido herdado da classe mãe InteracaoUsuario
            Pedido.SolicitarDigitacao();
            Pedido.MostrarDigitacao();

            // Recuperamos pelo metodo GET o valor da mensagem digitada para futura manipulação
            var Digitado = Pedido.Mensagem;

            // Escrevemos a nova mensagem colocando toda a mensagem em Maiusculas
            Console.WriteLine("Nova Digitação sem Espaços -> " + Digitado?.ToUpper());
        }
    }
}