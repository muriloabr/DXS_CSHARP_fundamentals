using System;

namespace DXS_CSHARP_fundamentals.MethodsAndClasses
{
    public class GetSet
    {
        public class Vehicle{
            //ATRIBUTOS PRIVADOS IMPLICITAMENTE SEM TRATAMENTO DE LEITURA E ESCRITA
            int cilindrada;
            double preco;
             //PROPRIEDADE PUBLICA DE CLASSSE | ESTATICO COM GET | PROIBINDO ESCRITA | LEITURA SOMENTE
            public static double Desconto { 
                get => 0.5;
            }

            //PROPRIEDADE PUBLICA AUTOIMPLEMENTADA COM GET E SET | SEM TRATAMENTO DE LEITURA E ESCRITA
            public string Tipo {get;set;}

            //PROPRIEDADE PUBLICA IMPLEMENTADA COM TRATAMENTO DE LEITURA E ESCRITA
            public int Cilindrada{
                get{
                    return cilindrada;
                }
                set{
                    if(value<1){
                        cilindrada = 10;
                    } else {  
                        cilindrada = value;
                    }
                }
            }
            
            public double Preco {
                get {
                    return this.preco;
                }
                set {
                    if(value<1){
                        this.preco = 0;
                    } else {  
                        this.preco = value;
                    }
                }
            }
            //PROPRIEDADE COM SOMENTE COM GET | LEITURA SOMENTE
            public double PrecoComDesconto {
                get => Preco - (Desconto * Preco);
                /*OUTRO MEDO DE CRIAR O MESMO RESULTADO
                get {
                    return Preco - (desconto * preco);     
                }*/
            }

            //CONTRUTORES
            public Vehicle(){}
            public Vehicle(string tipo, int cilindrada, double preco){
                Cilindrada = cilindrada;
                Tipo = tipo;
                Preco = preco;
            }
            public void exibirVeiculo(){
                Console.WriteLine($"Veiculo: {Tipo} | {Cilindrada} .CIL | {Preco.ToString("C2")} | Com {(Desconto*100)}% de desconto: {PrecoComDesconto.ToString("C2")}");
                
            }
        }
        
        public static void Execute(){
            //SETANDO VALORES INVALIDOS
            Vehicle veiculo1 = new Vehicle("Moto", -125, -3456.465);
            veiculo1.exibirVeiculo();
            //SETANDO VALORES VALIDOS
            Vehicle veiculo2 = new Vehicle("Moto", 125, 3456.465);
            veiculo2.exibirVeiculo();
        }
    }
}