using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXS_CSHARP_fundamentals.MethodsAndFunctions
{
    public static class ExtensoesInteiro
    {
        //METODO STATIC + (THIS + TIPO DO PARAMETRO) = REVELA SER UM METODO DE EXTENSÃO! QUE SÓ PODE SER CRIADO DENTRO DE UMA CLASSE ESTATICA
        public static int Somar(this int num, int outroNum)
        {
            return num + outroNum;
        }
        //METODO DE EXTENSAO FICA DISPONIVEL NATURALMENTE PARA TODO O [ASSEMBLY] NO TIPO DE VALOR SETADO COMO PARAMETRO
        public static string Subtrair1000(this int num)
        {
            return (num - 1000).ToString();
        }
    }

    class ExtensionMethods
    {
        public static void Execute()
        {
            int numero = 1560;
            Console.WriteLine(numero.Somar(40));
            Console.WriteLine(numero.Subtrair1000());
        }
    }
}
