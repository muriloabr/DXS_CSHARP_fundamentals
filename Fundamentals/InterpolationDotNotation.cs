using System;

namespace DXS_CSHARP_fundamentals
{
    public class InterpolationDotNotation
    {
        public static void Execute(){
            string _nomeClasse = "Interpolation"; string _acao = "executada";

            //METODOS DE INTERPOLACAO DE STRING
             Console.WriteLine("Essa classe " + _nomeClasse?.ToUpper().Replace("INTERPOLATION", "INTERPOLAÇÃO") + " foi '"+ _acao + "'!");
            Console.WriteLine("Essa classe {0} foi '{1}'! ", _nomeClasse?.ToUpper(), _acao);
            _nomeClasse = null;
            // ? APLICADO ANTES DO MÉTODO PREVINE EXCEPTION CASO FOR OBJETO NULO
            Console.WriteLine($"Essa classe {_nomeClasse?.ToUpper()} foi '{_acao}'!");
        }
    }
} 