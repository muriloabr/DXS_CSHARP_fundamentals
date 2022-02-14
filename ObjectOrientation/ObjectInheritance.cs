using System;

namespace DXS_CSHARP_fundamentals.ObjectOrientation
{
    public class Carro {
        protected readonly int VeliocidadeMaxima;
        //PRIVATE ACESSO SOMENTE DENTRO DA CLASSE
        private int VeliocidadeAtual;
        //PUBLIC TODOS TERÃO ACESSO TOTAL
        public Carro(int veliocidadeMaxima) {
            VeliocidadeMaxima = veliocidadeMaxima;
        }
        //ACESSO SOMENTE POR HERANÇA
        protected int AlterarVelocidade(int delta){
            int novaVelocidade = VeliocidadeAtual + delta;
            if (novaVelocidade <0) {
                VeliocidadeAtual = 0;
            } else if (novaVelocidade > VeliocidadeMaxima){
                VeliocidadeAtual = VeliocidadeMaxima;
            } else{
                VeliocidadeAtual = novaVelocidade;
            }
            return VeliocidadeAtual;
        }

        //VIRTUAL LIBERA O METODO PARA SER SOBRESCRITO
        public virtual int Acelerar(){
            return AlterarVelocidade(5);
        }
        //METODO NÃO VIRTUAL QUE VAI SER SOBRESCRITO COM NEW INT FREAR()
        public int Frear(){
            return AlterarVelocidade(-5);
        }        
    }

    public class FiatUno: Carro {
        public FiatUno(): base(160) {

        }
    }
    public class Ferrari: Carro {
        public Ferrari(): base(380) {

        }
        //METODO SENDO SOBRESCRITO
        public override int Acelerar(){
            return AlterarVelocidade(25);
        }
        //METODO SENDO SOBRESCRITO NO MODO OCULTAÇÃO DE MÉTODO
        //SENDO CHAMADO O METODO ORIGINAL DO PAI SE O TIPO FOR O DA HERANÇA
        public new int Frear() {
            return AlterarVelocidade(-30);
        }
    }

    public class ObjectInheritance
    {
        public static void Execute(){
            FiatUno carro1 = new FiatUno();
            Console.WriteLine($"NASCENDO UM UNO!");
            Console.WriteLine($"{carro1.Acelerar()}");
            Console.WriteLine($"{carro1.Acelerar()}");
            Console.WriteLine($"{carro1.Frear()}");
            Console.WriteLine($"{carro1.Acelerar()}");
            Console.WriteLine($"{carro1.Frear()}");
            Console.WriteLine($"{carro1.Frear()}");

            Ferrari carro2 = new Ferrari();
            Console.WriteLine($"NASCENDO UMA FERRARI!");
            Console.WriteLine($"{carro2.Acelerar()}");
            Console.WriteLine($"{carro2.Acelerar()}");
            Console.WriteLine($"{carro2.Frear()}");
            Console.WriteLine($"{carro2.Acelerar()}");
            Console.WriteLine($"{carro2.Frear()}");
            Console.WriteLine($"{carro2.Frear()}");

            Carro carro3 = new Ferrari();
            Console.WriteLine($"NASCENDO UM CARRO MODIFICADO!");
            Console.WriteLine($"{carro3.Acelerar()}");
            Console.WriteLine($"{carro3.Acelerar()}");
            carro3 = new FiatUno();
            Console.WriteLine($"{carro3.Acelerar()}");
            Console.WriteLine($"{carro3.Acelerar()}");
            Console.WriteLine($"{carro3.Frear()}");
            Console.WriteLine($"{carro3.Frear()}");
            
        }
    }
}