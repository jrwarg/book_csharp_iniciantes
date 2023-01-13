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
        public Revistas( int _MesPublicacao, int _AnoPublicacao)
        {
            _MesPublicacao = _MesPublicacao;
            _AnoPublicacao = AnoPublicacao;
            
        }
    }
}

