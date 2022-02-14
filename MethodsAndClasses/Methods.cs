using System;

namespace DXS_CSHARP_fundamentals.MethodsAndClasses
{
    class CalculadoraSimples{
        //ATRIBUTO DE CLASSE
        public static double energiaBateria = 0.0;
        public double energiaBateriaExtra = 0.0;
        //METODOS COM NOMES IGUAIS EXISTEM MAS COM PARAMETROS DE TIPOS DIFERENTES
        public int Somar(int a, double b){
            return a + (int)b;
        }        public int Somar(double a, int b){
            return (int)a + b;
        }
        public int Somar(int a, int b){
            return a + b;
        }
        public int Subtrair(int a, int b){
            return a - b;
        }
        public int Multiplicar(int a, int b){
            return a * b;
        }
        //METODO DE CLASSE ESTATICO
        public static string TarefasPossiveis(){
            return "SOMAR | SUBTRAIR | MULTIPLICAR";
        }
        //ACESSO DE ATRIBUTO EESTATICOO DENTRO DE UM MÉTODO DE CLASSE
        public static void carregarTodasAsCalculadoras(double carga){
            if(energiaBateria + carga > 1.0){
                energiaBateria = 1.0;
            } else {
                energiaBateria += carga;
            }
        }
        //ACESSO DE ATRIBUTO EESTATICOO DENTRO DE UM MÉTODO DE INSTANCIA | NÃO PODE HAVER ACESSO DE INSTANCIA NUM METODO EEESTATICOO
        public void exibirCargaBateria(){
           Console.WriteLine("Estamos com: " + energiaBateria*100 + "% de bateria!");
        }
        public void exibirCargaBateria(string nomeIdentificador){
           Console.WriteLine($"Estamos com a calculadora {nomeIdentificador} em: " + energiaBateria*100 + "% de bateria!");
        }
    }
    class CalculadoraEncadeada{
        int memoria;
        public CalculadoraEncadeada Somar(int a){
            memoria += a;
            return this;
        }
        public CalculadoraEncadeada Multiplicar(int a){
            memoria *= a;
            return this;
        }
        public CalculadoraEncadeada Subtrair(int a){
            memoria -= a;
            return this;
        }
        public CalculadoraEncadeada Limpar(){
            memoria = 0;
            return this;
        }
        public CalculadoraEncadeada ImprimirNoConsole(){
            Console.WriteLine($"Valor : {memoria}");            
            return this;
        }
        public int Resultado(){
            return memoria;
        }
    }

    public class Methods
    {
        public static void Execute(){
            //TRABALHANDO COM METODO DE CLASSE [EESTATICOO] E ATRIBUTO DE CLASSE [EESTATICOO] 
            Console.WriteLine("O QUE É POSSIVEL FAZER NA CALCULADORA SIMPLES?: " + CalculadoraSimples.TarefasPossiveis());
            var calcSimples1 = new CalculadoraSimples();
            var calcSimples2 = new CalculadoraSimples();
            calcSimples1.exibirCargaBateria("PRIMEIRA");
            calcSimples2.exibirCargaBateria("SEGUNDA");
            //METODO ESTATICO
            CalculadoraSimples.carregarTodasAsCalculadoras(0.48);
            //ATRIBUTO ESTATICO
            CalculadoraSimples.energiaBateria -= 0.22;
            calcSimples1.exibirCargaBateria("PRIMEIRA");
            calcSimples2.exibirCargaBateria("SEGUNDA");

            var calcEnc = new CalculadoraEncadeada();            
            //CHAMADA ENCADEADA DOTNOTATION POR TODOS OS METODOS RETORNAREM O MESMO OBJETO, SENDO POSSIVEL CHAMAR MAIS METODOS DE CADA RESULTADO OBTIDO
            calcEnc.Somar(3).Multiplicar(3).ImprimirNoConsole().Limpar().ImprimirNoConsole();
            //CHAMADA ENCADEADA VAI ATÉ O MÈTODO QUE NÃO RETORNA MAIS O PRÓPRIO OBJETO
            Console.WriteLine($"RESULTADO : {calcEnc.Somar(6).Multiplicar(9).Subtrair(3).Resultado()}");
        }
    }
}