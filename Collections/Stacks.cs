using System;
using System.Collections;

namespace DXS_CSHARP_fundamentals.Collections
{
    public class Stacks
    {

        //METODO DE AUXILIO PARA EXIBIR OS ITEMS
        static void exibirPilha(Stack lista ){
            //USO DE COUNT PARA OBTER O TAMANHO DA PILHA
            Console.WriteLine($"Tamanho da pilha: {lista.Count}");
            //LEITURA AO CONTRARIO DO ULTIMO ELEMENTO AO PRIMEIRO                
            foreach(var item in lista) {
                Console.WriteLine($"{item}");                    
            }
        }
        public static void Execute(){
            //PILhA É LIFO E É HETEROGENEA, ACEITA ATRIBUIÇÃO DE VALORES VARIADOS E NÃO É INDEXADA 
            var pilha = new Stack();

            //ATRIBUICAO SIMPLES DE UM ITEM A PILHA
            pilha.Push("primeiro a ser colocado na pilha");
            pilha.Push('s');
            pilha.Push(true);
            pilha.Push("stringaleatoria");
            pilha.Push(13.45);

            exibirPilha(pilha);

            //METODO PARA REMOVER O ULTIMO ELEMENTO DA PILHA
            Console.WriteLine($"REMOVENDO: {pilha.Pop()}");
            
            exibirPilha(pilha);

            Console.WriteLine($"Ultmo elemento adicionado a pilha = {pilha.Peek()}");
            
        }
    }
}