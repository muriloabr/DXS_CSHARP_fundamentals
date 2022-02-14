using System;
using System.Collections;
using System.Collections.Generic;

namespace DXS_CSHARP_fundamentals.Collections
{
    public class Queues
    {
        //METODO DE AUXILIO PARA EXIBIR OS ITEMS
        static void exibirFila(Queue<string> lista ){
            //USO DE COUNT PARA OBTER O TAMANHO DA FILA
            Console.WriteLine($"Tamanho da fila: {lista.Count}"); 
            //LEITURA PADRAO DO PRIMEIRO ELEMENTO AO ULTIMO              
            foreach(var item in lista) {
                Console.WriteLine($"{item}");                    
            }
        }
        public static void Execute(){
            //FILA SENDO INSTACIADA COM USO DO GENERICS
            var fila = new Queue<string>();

            //ATRIBUICAO SIMPLES DE UM ITEM A FILA
            fila.Enqueue("Primeiro a chegar");
            fila.Enqueue("Segundo a chegar");
            fila.Enqueue("Terceiro a chegar");

            //METODO PARA RETORNAR O PRIMEIRO DA FILA
            Console.WriteLine($"{fila.Peek()}");

            //METODO PARA REMOVER O PRIMEIRO DA FILA
            Console.WriteLine($"Saiu o : {fila.Dequeue()}");    

            exibirFila(fila);

            //FILA SENDO INSTACIADA SEM USO DO GENERICS
            var filaDois = new Queue();

            //QUEUE É FIFO E É HETEROGENEA, ACEITA ATRIBUIÇÃO DE VALORES VARIADOS E NÃO É INDEXADA
            filaDois.Enqueue('y');
            filaDois.Enqueue(true);
            filaDois.Enqueue("!!");
            filaDois.Enqueue(4489915.65);
            filaDois.Enqueue(new Produto(preco: 435.785, nome: "Nome"));

            //CONTAINS VERIFICA SE TEM NA FILA O ITEM
            Console.WriteLine($"Tem o '!!'? : {filaDois.Contains("!!")}");            
        }
    }
}