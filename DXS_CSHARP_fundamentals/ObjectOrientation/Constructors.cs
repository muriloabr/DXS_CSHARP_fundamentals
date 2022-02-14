using System;

namespace DXS_CSHARP_fundamentals.ObjectOrientation
{
    public class Animal{
        public string Nome {get;set;}
        public Animal(string nome){
            Nome = nome;
        }
    }

    public class Boi: Animal{    
        public int Peso {get;set;}
        //CONSTRUTOR CHAMANDO O DA BASE(nome) E CONSTRUINDO A BASE DA CLASSE ANIMAL
        public Boi(string nome): base(nome){
            Console.WriteLine($"Boi sendo criado usando constructor de Animal setou Nome = {Nome}");            
        }
        //CONSTRUTOR CHAMANDO O DE CIMA QUE CHAMA O DA BASE(nome) COM this(nome)
        public Boi(string nome, int peso): this(nome){
            Peso = peso;
            Console.WriteLine($"Boi sendo criado e engordado usando constructor de da classe setou Peso = {Peso}"); 
        }
        public override string ToString()
        {
            return $"O Boi tem nome: {Nome} e pesa {Peso}Kgs";
        }
    }

    public class Constructors
    {
        public static void Execute(){
            //INSTANCIANDO COM CONSTRUTOR DE CLASSE!
            var bernado = new Boi("Bernado", 789);
            var coimbra = new Boi("Coimbra", 459);
            //REPARE QUE A ORDEM DE CONSTRUTORES É DA HERANÇA PARA BAIXO 
            Console.WriteLine($"{bernado} | {coimbra}");
            
        }
    }
}