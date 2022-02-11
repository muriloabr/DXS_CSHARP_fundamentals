using System;

namespace DXS_CSHARP_fundamentals.Fundamentals
{
    class VariablesAndConstants {
        public static void Execute(){                     
            Console.WriteLine("STRING | valores: TEXTO" + " tamanho: variavél"); 
            Console.WriteLine("CHAR | valores: CARACTER" + " tamanho: " + sizeof(char) + "bits");          
            Console.WriteLine("BOOLEAN | valores: TRUE | FALSE" + " tamanho: " + sizeof(bool) + "bits");
            Console.WriteLine("SBYTE | mínimo:" + sbyte.MinValue + " máximo: " + sbyte.MaxValue + " tamanho: " + sizeof(sbyte) + "bits"); //signed byte : pode ser negativo
            Console.WriteLine("BYTE | mínimo:" + byte.MinValue + " máximo: " + byte.MaxValue + " tamanho: " + sizeof(byte) + "bits"); 
            Console.WriteLine("SHORT | mínimo:" + short.MinValue + " máximo: " + short.MaxValue + " tamanho: " + sizeof(short) + "bits"); 
            Console.WriteLine("INTEGER | mínimo:" + int.MinValue + " máximo: " + int.MaxValue + " tamanho: " + sizeof(int) + "bits");
            Console.WriteLine("UINTEGER | mínimo:" + uint.MinValue + " máximo: " + uint.MaxValue + " tamanho: " + sizeof(uint) + "bits"); //unsigned : não pode ser negativo
            Console.WriteLine("LONG | mínimo:" + long.MinValue + " máximo: " + long.MaxValue + " tamanho: " + sizeof(long) + "bits"); 
            Console.WriteLine("ULONG | mínimo:" + ulong.MinValue + " máximo: " + ulong.MaxValue + " tamanho: " + sizeof(ulong) + "bits"); //unsigned : não pode ser negativo
            Console.WriteLine("FLOAT | mínimo:" + float.MinValue + " máximo: " + float.MaxValue + " tamanho: " + sizeof(float) + "bits");            
            Console.WriteLine("DOUBLE | mínimo:" + double.MinValue + " máximo: " + double.MaxValue + " tamanho: " + sizeof(double) + "bits");
            Console.WriteLine("DECIMAL | mínimo:" + decimal.MinValue + " máximo: " + decimal.MaxValue + " tamanho: " + sizeof(decimal) + "bits");      
            //ATIBUIÇÃO DE NUMERO USANDO UNDERSCORE PARA MELHOR LEITURA
            int _integer = 2_147_483_647;
            Console.WriteLine("15_456_656_890 Ex. " + _integer);
            //CONSTANTE
            const int _constanteInalteravel = 1_235_235 ;
            Console.WriteLine("const são CONSTANTES INALTERÁVEIS : " + _constanteInalteravel);
        }
    }

}