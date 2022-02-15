using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXS_CSHARP_fundamentals.AdvancedTopics
{
    internal class Nullables
    {
        //VARIAVEI DE NIVEL DE CLASSE AUTOMATICAMENTE INICIALIZADA POR VALOR PADRAO
        static int numeroEstatico;
        public static void Execute()
        {
            //TIPO NULLABLES PODEM RECEBER O NULL COMO VALOR
            Nullable<bool> tresEstagios = null;
            Nullable<int> numNulo = null;
            //TIPO? = PODE RECEBER NULO
            int? numeroPodeSerNulo = null;
            //IMPOSSIVEL COMPILAR SEM INICIALIZAR INTEGERS POIS NAO RECEBEM NENHUM VALOR POR PADRAO E NAO ALOCAM MEMORIA
            //int numeroSemInicializacao = null; //ATRIBUICAO DE NULL NORMAL NAO PODE
            Console.WriteLine("INT? : " + numeroPodeSerNulo); //EXIBE NULL
            Console.WriteLine("STATIC : " + numeroEstatico); //VARIAVEL ESTATICA PODE SER UTILIZADAS SEM INICIALIZAR, POIS SEMPRE SAO INICIALIZADAS COM VALORES PADROES
            Console.WriteLine("NULLABLE TEM VALOR? " + tresEstagios.HasValue + " | QUAL O VALOR ATUAL? "+ tresEstagios);
            //?? SE NAO HOUVER PARENTESES ISOLANDO A COMPARACAO TODO CALCULO DO LADO ESQUERDO SE CONTIVER NULO SERA SUBSTITUIDO PELO CALCULO DA DIREITA
            int resultado1 = 100 + numNulo ?? 100 + 201;
            Console.WriteLine(" 100 + 201 = " + resultado1);
            //QUANDO TODO CALCULO CONTEM TIPOS PRIMITIVOS DE INT E NAO INT? ENTAO O USO DO ?? É PROIBIDO
            int resultado2 = 100 + numNulo.GetValueOrDefault();
            Console.WriteLine(" 100 + 201 = " + resultado2);
        }
    }
}
