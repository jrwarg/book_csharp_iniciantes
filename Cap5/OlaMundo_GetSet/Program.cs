using System;

namespace MinhaPrimeiraClasse
{
    class ProgramaPrincipal
    {
        static void Main(string[] args)
        {
            //  Criamos o objeto Pedido herdado da classe Interacao Usuario
            InteracaoUsuario Pedido = new InteracaoUsuario();
            // Invocamos os métodos do objeto Pedido da classe mãe InteracaoUsuario:
            Console.Write("Digite algo: ");
            Pedido.SolicitarDigitacao();
            Pedido.MostrarDigitacao();

            // Recuperar pelo metodo GET o valor da mensagem digitada para manipulação
            var Digitado = Pedido.Mensagem;
            // Escrever a nova mensagem colocando-a em Maiuscula
            Console.WriteLine("Nova Digitação sem espaços -> " + Digitado?.ToUpper());
        }
    }

    class InteracaoUsuario
    {
        private string? _MensagemDigitada;

        public string? Mensagem
        {
            get
            {
                return _MensagemDigitada;
            }
            set
            {
                _MensagemDigitada = value;
            }
        }

        public void SolicitarDigitacao()
        {
            _MensagemDigitada = ($"Texto digitado: {Console.ReadLine()}");
        }

        public void MostrarDigitacao()
        {
            Console.WriteLine(_MensagemDigitada);
        }
    }

}