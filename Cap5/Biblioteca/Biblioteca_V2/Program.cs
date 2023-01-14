using System;
using static System.Console;
using Libraryclass;

namespace Biblioteca_V2
{
    class Program
    {
        static void Main(string[] args)
        {
            // inicializando nossa nova classe com herança
            Revistas MinhasRevistas = new Revistas(3, 2021);
            // inicializando as outras propriedades da classe que foram herdadas
            MinhasRevistas.Autor = "Microsoft";
            MinhasRevistas.Titulo = "MSDN Magazine";
            MinhasRevistas.Paginas = 20;
            MinhasRevistas.Status = true;
            // Imprimindo os valores de minha classe
            WriteLine("Revista Mes: " + MinhasRevistas.MesPublicacao);
            WriteLine("Revista Ano: " + MinhasRevistas.AnoPublicacao);
            WriteLine("Revista Autor: " + MinhasRevistas.Autor);
            WriteLine("Revista Título: " + MinhasRevistas.Titulo);
            WriteLine("Revista Páginas: " + MinhasRevistas.Paginas);
            WriteLine("Revistas Status: " + MinhasRevistas.Status);
            WriteLine();
            // Inicializando nossa classe com o construtor nulo
            Biblioteca MinhaBiblioteca = new Biblioteca();
            // Porisso a necessidade de "setar" o valor de cada propriedade
            MinhaBiblioteca.Autor = "Des Dearlove";
            MinhaBiblioteca.Titulo = "O Estilo Bill Gates de Gerir";
            MinhaBiblioteca.Paginas = 203;
            MinhaBiblioteca.Status = true;
            // Imprimindo os valores de minha classe
            WriteLine("Autor: " + MinhaBiblioteca.Autor);
            WriteLine("Título: " + MinhaBiblioteca.Titulo);
            WriteLine("Páginas: " + MinhaBiblioteca.Paginas);
            WriteLine("Status: " + MinhaBiblioteca.Status);
            WriteLine();
            // Inicializando nossa classe com o novo construtor:
            Biblioteca MeusLivros = new Biblioteca("Juan Garcia Sola", "Linguagem C", 296, true);
            // Imprimindo os valores de minha classe
            WriteLine("Autor: " + MeusLivros.Autor);
            WriteLine("Título: " + MeusLivros.Titulo);
            WriteLine("Páginas: " + MeusLivros.Paginas);
            WriteLine("Status: " + MeusLivros.Status);
            WriteLine();
            // Inicializando nossa nova classe Fotos:
            Fotos MinhasFotos = new Fotos("Colorida");
            MinhasFotos.AnoPublicacao = 2021;
            MinhasFotos.MesPublicacao = 3;
            MinhasFotos.Autor = "Desconhecido";
            MinhasFotos.Titulo= "Vida Eterna";
            MinhasFotos.Paginas = 1;
            MinhasFotos.Status = true;
            // Imprimindo os valores de minha classe
            WriteLine("Foto Tipo: " + MinhasFotos.Tipo);
            WriteLine("Foto Mês: " + MinhasFotos.MesPublicacao);
            WriteLine("Foto Ano: " + MinhasFotos.AnoPublicacao);
            WriteLine("Foto Autor: " + MinhasFotos.Autor);
            WriteLine("Foto Título: " + MinhasFotos.Titulo);
            WriteLine("Foto Páginas: " + MinhasFotos.Paginas);
            WriteLine("Foto Status: " + MinhasFotos.Status);
            WriteLine();
            
        }
    }
}