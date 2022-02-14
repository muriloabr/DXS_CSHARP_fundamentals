using System;

namespace DXS_CSHARP_fundamentals.MethodsAndFunctions
{
    internal class Lambda
    {
        public static void Execute()
        {
            //ACTION = VARIAVEL QUE RECEBE A LAMBDA/FUNCAO ANONIMA | ACTION ACEITA SOMENTE FUNÇÕES SEM RETORNO
            Action algoNoConsole1 =
            //LAMBDA = FUNCAO ANONIMA
            () =>
            {
                Console.WriteLine("LAMBDA EXECUTANDO!");
            };
            algoNoConsole1();

            //ACTION PODE RECEBER VARIOS PARAMETROS PELO GENERIC
            Action<int, int> algoNoConsole2 =
            (numero, numero1) =>
            {
                Console.WriteLine("LAMBDA EXECUTANDO! COM PARAMETROS: " + numero+numero1);
            };
            algoNoConsole2(458, 2897);

            //FUNC = VARIAVEL QUE RECEBE A LAMBDA/FUNCAO ANONIMA | FUNC ACEITA FUNÇÕES COM RETORNO
            Func<int> jogarDado =
            () =>
            {
                Random random = new Random();
                return random.Next(1, 7);
            };
            Console.WriteLine("O DADO CAIU: " + jogarDado());

            //FUNC<TODOS PARAMETROS DE ENTRADA, ULTIMO ITEM = TIPO DE RETORNO>
            Func<int, int, string> somando1 =
            (numero1, numero2) =>
            {
                //LAMBDA COM BLOCO E RETORNO EXPLICITO
                return "SOMA1: " + (numero1 + numero2).ToString();
            };
            Console.WriteLine(somando1(1, 2));
            //LAMBDA COM RETORNO IMPLICITO
            Func<int, int, string> somando2 = (numero1, numero2) => "SOMA2: " + (numero1 + numero2).ToString();            
            Console.WriteLine(somando2(5, 2));
            //UM ITEM NO GENERIC ENTAO É O RETORNO SENDO UMA FUNCAO SEM PARAMETROS
            Func <int> semParametros = () => (5666+9787);
            Console.WriteLine("Cálculo sem parametros: " + semParametros());
        }
    }
}
