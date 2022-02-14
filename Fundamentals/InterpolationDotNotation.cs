using System;

namespace DXS_CSHARP_fundamentals
{
    public class InterpolationDotNotation
    {
        public static void Execute(){
            string _nomeClasse = "Interpolation"; string _acao = "executada";

            //METODOS DE INTERPOLACAO DE STRING
            //POR ORDEM DE VARIAVEL {0}{1}{2}
             Console.WriteLine("Essa classe {0} foi '{1}'! ", _nomeClasse?.ToUpper(), _acao);
            //POR METODO SIMPLES E AINDA USANDO ? : APLICADO ANTES DO MÉTODO PREVINE EXCEPTION CASO FOR OBJETO NULO
            _nomeClasse = null;
            Console.WriteLine("Essa classe " + _nomeClasse?.ToUpper().Replace("INTERPOLATION", "INTERPOLAÇÃO") + " foi '"+ _acao + "'!");            
            //@ ANTES EVITA CARACTER ESPECIAL DAR PROBLEMA
            Console.WriteLine(@"\nota\caminhoQuePodeQuebrarLinha\alog.txt");
            _nomeClasse = "Interpolation";
            //POR METODO USANDO $ E {VARIAVEL}
            Console.WriteLine($"Essa classe {_nomeClasse?.ToUpper()} foi '{_acao}'!");
        }
    }
} 