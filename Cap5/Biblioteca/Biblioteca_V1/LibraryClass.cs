namespace Libraryclass
{
    // principal classe de controle de livros na Biblioteca
    public class Biblioteca
    {
        private string? _Titulo; // recebe o título do livro
        private string?_Autor; // recebe o nome do autor do Livro
        private int? _Paginas;// recebe o nr. de páginas que o livro contem
        private bool? _Status; // recebe saindo (FALSE) ou entrando (TRUE) na biblioteca

        public Biblioteca() // construtor sem parâmetros
        {

        }
        // Construtor com parâmetros
        public Biblioteca( string Titulo, string Autor, int Paginas, bool Status)
        {
            _Titulo = Titulo;
            _Autor = Autor;
            _Paginas = Paginas;
            _Status = Status;
        }

        public string? Titulo // Método para acesso à propriedade Título da classe
        {
            get {return _Titulo;} set {_Titulo = value;}
        }
        public string? Autor // Método para acesso à propriedade Autor da classe
        {
            get {return _Autor;} set {_Autor = value;}
        }
        public int? Paginas // Método para acesso à propriedade P[áginas] da classe
        {
            get {return _Paginas;} set {_Paginas = value;}
        }
        public bool? Status // Método para acesso à propriedade Status da classe
        {
            get {return _Status;} set {_Status = value;}
        }
        // Método Descarte
        public virtual void Descarte()
        {
            _Titulo = "O livro foi Doado";
        }
        
    }
}