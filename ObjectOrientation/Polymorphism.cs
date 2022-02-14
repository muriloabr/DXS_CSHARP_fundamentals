using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXS_CSHARP_fundamentals.ObjectOrientation
{
    class Comida
    {
        public double Peso { get; set; }  
        public Comida(double peso) { Peso = peso; } 
    }
    class Sobremesa : Comida
    {
        public Sobremesa(double peso) : base(peso)
        {
        }
    }
    class Janta : Comida
    {
        public Janta(double peso) : base(peso)
        {
        }
    }
    class Almoco : Comida
    {
        public Almoco(double peso) : base(peso)
        {
        }
    }

    class Pessoa
    {
        public double Peso { get; set; }
        public Pessoa()
        {
            Peso = 56;
        }
        /* COM HERANÇA DE COMIDA NÃO PRECISA ESPECIFICAR O TIPO PARA SE ENGORADAR COMENDO COMIDA
        public void Comer(Janta jantar)
        {
            Peso += jantar.Peso;
        }
        public void Comer(Sobremesa sobremesa)
        {
            Peso += sobremesa.Peso;
        }
        public void Comer(Almoço almoço)
        {
            Peso += almoço.Peso;
        }
        */
        public void Comer(Comida comidaQualquer) {
            Peso += comidaQualquer.Peso;
            Console.WriteLine("COMENDO....");
        }

        public override string ToString()
        {
            return $"Agora estou pesando: {Peso}";
        }
    }

    internal class Polymorphism
    {
        public static void Execute()
        {
            Pessoa pessoa = new Pessoa();
            Console.WriteLine(pessoa);
            //RECEBENDO COMIDAS DE MODO POLIMORFICO
            pessoa.Comer(new Almoco(1.2));
            pessoa.Comer(new Sobremesa(0.8));
            pessoa.Comer(new Janta(1.4));
            Console.WriteLine(pessoa);
        }
    }
}
