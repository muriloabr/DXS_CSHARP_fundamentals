using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXS_CSHARP_fundamentals.MethodsAndFunctions
{
    //DELEGATE CRIA UM TIPO, ENTAO PODE CRIAR VARIAVEIS, CONSTANTES E PARAMETROS DE FUNCOES QUE RECEBEM ESSE TIPO 
    delegate double Operacao(double x, double y);
    delegate void ImprimirOperacao(double x, double y);    
    internal class Delegate
    {
        public static void Execute()
        {
            //DELEGATE DEFINE O TIPO AUTOMATICAMENTE DOS PARAMETROS E DO RETORNO DAS FUNCOES QUE ELE PODE RECEBER
            Operacao somar = (primeiro, segundo) => primeiro + segundo;
            Operacao subtrair = (primeiro, segundo) => primeiro - segundo;
            Console.WriteLine(somar(1.4,0.4));
            Console.WriteLine(subtrair(450.58, 150.38));

            static void ImpressaoMinha(double x, double y)
            {
                Console.WriteLine("ImpressaoMinha : " + (x * y + x - y));
            }

            static double fazerUmaSoma(double x, double y)
            {
                return (x + y);
            }

            //ATIBUIÇÃO SIMPLES DE UM DELEGATE COM UMA FUNCAO PRONTA
            Operacao delegateFazendoSoma = fazerUmaSoma;
            Console.WriteLine("delegateFazendoSoma : " + delegateFazendoSoma(45.75, 536));

            //FUNC RECEBENDO O MESMO METODO QUE O DELEGATE
            Func<double,double,double> funcFazendoSoma = fazerUmaSoma;
            Console.WriteLine("funcFazendoSoma : " + funcFazendoSoma(465,564));
            
            //ACTION NAO PODE RECEBER METODO COM RETORNO
            Action<double, double> actionFazendoSoma = ImpressaoMinha;
            actionFazendoSoma(565,7676);

            //DELEGATE RECEBENDO UMA FUNCAO ANONIMA
            Operacao operarComFuncaoAnonima =
                delegate (double primeiroParam, double primeiroParam2)
                {
                    return primeiroParam*primeiroParam2;
                };

            //UM PARAMETRO DO TIPO DELEGATE RECEBE O METODO COM MESMAS ASSINATURAS DE PARAMETROS E RETORNO
            static string InformarResultado (Operacao operacaoParam, int fatorMult)
            {
                return " FUNCAO: " + operacaoParam.Method + " | RESULTA EM: " + (operacaoParam(5,6) * fatorMult).ToString();
            }
            Console.WriteLine(InformarResultado(operarComFuncaoAnonima, 2));
            Console.WriteLine(InformarResultado(fazerUmaSoma, 2));
        }
    }
}
