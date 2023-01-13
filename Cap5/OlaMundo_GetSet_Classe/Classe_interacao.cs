using System;

// Classe InteracaoUsuario com dois metodos principais
// Método que solicita a digitação de algo no terminal
// Método que mostra o que foi digitado 

namespace MinhaClasseUsuario
{
    public class InteracaoUsuario
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
            _MensagemDigitada = Console.ReadLine();
        }

        public void MostrarDigitacao()
        {
            Console.WriteLine(_MensagemDigitada);
        }
    }
}