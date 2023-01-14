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

        public override void Descarte()
        {
        this.Titulo = "A Revista foi descartada";
        }
    }

    public class Fotos : Revistas
    {
        // propriedades da classe:
        private string? _Tipo;
        // neste construtor precisamos referenciar a classe base Revistas
        // Revistas é uma classe já herdada de Biblioteca
        public Fotos (string Tipo) : base (0, 0)
        {
            _Tipo = Tipo;
        }
        public string? Tipo // Método para acesso à propriedade
        {
            get {return _Tipo;} set {_Tipo = value;}
        }
        // criando um método para Descarte
        public override void Descarte()
        {
            this.Titulo = "A foto foi destruída";
        }
    }
}

