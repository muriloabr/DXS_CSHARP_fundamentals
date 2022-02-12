using System;
using System.Globalization;

namespace DXS_CSHARP_fundamentals
{
    public class ReadAndWriteValues
    {
        public static void Execute(){
            Console.WriteLine("Digite seu salário: ");
            //CONVERTE PARA DOUBLE SEM CORRIGIR O USO DE PONTO E VÍRGULA CAPTURADO!
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //EXIBE COM INTERPOLACAO E FORMAT APLICADO - INICIO
            //ARREDONDA PARA 2 CASAS DECIMAIS
            Console.WriteLine("Digitado : {0}", salario.ToString("F2"));
            //FOMATA PARA MOEDA DA CULTURA ESCOLHIDA
            Console.WriteLine($"Digitado : {salario.ToString("C", CultureInfo.CreateSpecificCulture("en-us"))}");
            //PERCENTUAL = *100 ADICAO DE %
            Console.WriteLine("Digitado : {0}", salario.ToString("P"));
            //ARREDONDA PARA .### CASAS DECIMAIS
            Console.WriteLine("Digitado : {0}", salario.ToString("#.###"));
            
            //COMPLETA AS CASAS DECIMAIS COM 0 MANTENDO 10 POSIÇÕES PRENCHIDAS [SOMENTE PARA VARIAVEIS: INT]
            int salario_int = int.Parse(salario.ToString().Replace(".","").Replace(",",""));
            Console.WriteLine("Digitado : {0}", salario_int.ToString("D10"));
            //EXIBE COM INTERPOLACAO E FORMAT APLICADO - FIM
            
            Console.WriteLine("=========================================");

            //CONERSÃO DE VALORES - INICIO
            double _valorDouble = 1665.797;
            int _valorInteger = 1564;

            _valorDouble = _valorInteger; // VALOR RECEBIDO EM VARIAVEL MAIOR É: CONVERSÃO EXPLÍCITA POIS NÃO TEM PERDA DE DADOS
            Console.WriteLine("Converção implícita double = int : {0}", _valorDouble.ToString());

            _valorDouble = 9089.956;

            _valorInteger = (int) _valorDouble; // ARREDONDA RETIRANDO AS CASAS DECIMAIS
            Console.WriteLine("Converção explícita (int): {0}", _valorInteger.ToString());

            _valorInteger = int.Parse(((long) _valorDouble).ToString()); // SÓ CONVERTE STRINGS DE VALORES QUE FOREM REALMENTE INTEGERS = SEM CASAS DECIMAIS
            Console.WriteLine("Converção explícita int.Parse(): {0}", _valorInteger.ToString());

            _valorInteger = Convert.ToInt32(_valorDouble); // ARREDONDA QUALQUER NUMERO PARA CIMA USANDO AS CASAS DECIMAIS
            Console.WriteLine("Converção explícita Convert.ToInt32(): {0}", _valorInteger.ToString());
            
            int.TryParse(_valorDouble.ToString(), out _valorInteger); // SÓ CONVERTE STRINGS DE VALORES QUE FOREM REALMENTE INTEGERS = SEM CASAS DECIMAIS | SENÃO SETA VALOR ZERO
            Console.WriteLine("Converção explícita int.TryParse(out): {0}", _valorInteger.ToString());
            //CONERSÃO DE VALORES - FIM

            Console.WriteLine("=========================================");

            
        }
    }
} 