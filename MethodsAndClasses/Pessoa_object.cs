using System;

namespace DXS_CSHARP_fundamentals.MethodsAndClasses
{
    public class Pessoa_object {
        //ATRIBUTOS
        public string Nome;
        public int Idade;
        //CONSTRUTORES
        public Pessoa_object(string nome, int idade){
            Nome = nome;
            Idade = idade;
        }
        public Pessoa_object(){}
        //METODO COM RETORNO
        public string seApresentar(){
            return $"Eu sou {Nome} e tenho {Idade}anos.";
        }
        //METODO SEM RETORNO
         public void seApresentarNoConsole(){
            Console.WriteLine(seApresentar());            
        }
    }
}