// namespace que irá conter a classe de controle de revistas, livros e seus metodos
namespace Libraryclass
{
    // nova classe para controlas as revistas
    public class Revistas : Biblioteca
    {
        // Propriedades da Classe
        private int?_MesPublicacao;
        private int? _AnoPublicacao;
        // Construtor de classe:
        public Revistas( int MesPublicacao, int AnoPublicacao)
        {
            _MesPublicacao = MesPublicacao;
            _AnoPublicacao = AnoPublicacao;           
        }

        public int? MesPublicacao // Método para acesso à propriedade da classe
        {
            get {return _MesPublicacao;} set { _MesPublicacao = value;}
        }
        public int? AnoPublicacao
        { 
            get {return _AnoPublicacao;} set {_AnoPublicacao = value;}
        }
    }
}

