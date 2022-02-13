using System;

namespace DXS_CSHARP_fundamentals.MethodsAndClasses
{
    //LISTA UNUM DE VALORES PREDEFINIDOS
    public enum Genero { Acao, Aventura, Comedia }
    public class Filme{
        public string Titulo;
        public Genero GeneroFilme;
    }
    public class Enumerators
    {         
         public static void Execute(){
            //USOS DE ENUM
            int id = (int)Genero.Acao;
            Console.WriteLine($"{id}");
            var filme = new Filme();
            filme.Titulo = "Jurassic World";
            filme.GeneroFilme = Genero.Comedia;
            Console.WriteLine($"{filme.Titulo} é de {filme.GeneroFilme}!");                 
         }
    }
}