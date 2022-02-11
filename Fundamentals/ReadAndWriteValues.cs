using System;
using System.Globalization;

namespace DXS_CSHARP_fundamentals
{
    public class ReadAndWriteValues
    {
        public static void Execute(){
            System.Console.WriteLine("Digite seu salário: ");
            //CONVERTE PARA DOUBLE SEM CORRIGIR O USO DE PONTO E VÍRGULA CAPTURADO!
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //EXIBE COM INTERPOLACAO E FORMAT APLICADO - INICIO
            //ARREDONDA PARA 2 CASAS DECIMAIS
            System.Console.WriteLine("Digitado : {0}", salario.ToString("F2"));
            //FOMATA PARA MOEDA DA CULTURA ESCOLHIDA
            System.Console.WriteLine($"Digitado : {salario.ToString("C", CultureInfo.CreateSpecificCulture("en-us"))}");
            //PERCENTUAL = *100 ADICAO DE %
            System.Console.WriteLine("Digitado : {0}", salario.ToString("P"));
            //ARREDONDA PARA .### CASAS DECIMAIS
            System.Console.WriteLine("Digitado : {0}", salario.ToString("#.###"));
            
            //COMPLETA AS CASAS DECIMAIS COM 0 MANTENDO 10 POSIÇÕES PRENCHIDAS [SOMENTE PARA VARIAVEIS: INT]
            int salario_int = int.Parse(salario.ToString().Replace(".","").Replace(",",""));
            System.Console.WriteLine("Digitado : {0}", salario_int.ToString("D10"));
            //EXIBE COM INTERPOLACAO E FORMAT APLICADO - FIM
        }
    }
} 