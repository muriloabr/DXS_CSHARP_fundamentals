using System;
using System.Collections.Generic;
using System.Linq;

namespace DXS_CSHARP_fundamentals
{   
    //CONTROLADOR DE ESCOLHA DE EXEMPLOS A SEREM RODADOS!
    public class ExamplesController
    {
        //LISTA OFICIAL DOS MEUS EXEMPLOS JÁ CRIADOS!
         Dictionary<string, Action> allMyExamples;

        // CONSTRUTOR QUE RECEBE TODOS OS MEUS EXEMPLOS JÁ CRIADOS!
        public ExamplesController(Dictionary<string, Action> examplesList) { 
            this.allMyExamples = examplesList;    
        }
        public void SelectAndExecuteTheExample() {
            int i = 1;
            //EXIBINDO TODOS OS OS MEUS EXEMPLOS JÁ CRIADOS!
            foreach (var example in this.allMyExamples) {
                Console.WriteLine("{0}) {1}", i, example.Key);
                i++;
            }
            //MENSAGEM DE ESCOLHA DO EXEMPLO
            Console.Write("Digite o número do Exemplo ou prossiga com [ENTER] pra rodar o mais recente: ");
            //TENTA CONVERTER A RESPOSTA PARA INT E SETAR NA VARIAVEL num
            int.TryParse(Console.ReadLine(), out int num);
            //SE num OBTIVER NUMERO MAIOR QUE ZERO E DENTRO DO LIMITE DA QUANTIDADE DE EXEMPLOS JÁ CRIADOS!
            bool validNumber = (num > 0 && num <= this.allMyExamples.Count);
            //num RECEBE O VALOR PARA SER USADO COMO INDICE DE: ZERO A ARRAY.LENGTH -1
            num = (validNumber) ? num - 1 : this.allMyExamples.Count - 1;
            //exampleName RECEBE [KEY, VALUE] A KEY DO ITEM SELCIONADO NO DICTIONARY DE EXEMPLOS JÁ CRIADOS!
            string exampleName = this.allMyExamples.ElementAt(num).Key;
            //MENSAGEM DE EXECUÇÃO DO EXEMPLO ESCOLHIDO
            Console.Write("\nExecutando exercício: ");
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine(exampleName);
            Console.ResetColor();
            //CONCATENA O ENUMERABLE COM SIMBOLOS DE "=" REGISTRADOS DENTRO DELE,
            //SÃO 22 "=" PARA ACOMPANHAR O TITULO "\nExecutando exercício: " E
            //MAIS [X] REFERENTES A QUANTIDADE DE CARACTERES NO TITULO DO EXEMPLO SELECIONADO
            Console.WriteLine(String.Concat(
                Enumerable.Repeat("=", exampleName.Length + 22)) + "\n");
            //executar RECEBE [KEY, VALUE] O VALUE AGORA DO ITEM SELCIONADO, ESSE VALUE É
            //A REFERENCIA DO MÉTODO EXECUTAR() ENTÃO USA O DELEGATE Action PARA RECEBER ESSE MÉTODO
            Action executar = this.allMyExamples.ElementAt(num).Value;
            //EXECUTA O MÉTODO ESTATICO DO OBJETO REFERENCIADO DENTRO DA LISTA E SELECIONADO PELO USUARIO!
            try {
                executar();
            } catch(Exception e) {
                //MENSAGEM DE EXECUÇÃO COM ERRO IDENTIFICADO
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Ocorreu um erro: {0}", e.Message);
                Console.ResetColor();
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
