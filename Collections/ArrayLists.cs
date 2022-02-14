using System;
using System.Collections;

namespace DXS_CSHARP_fundamentals.Collections
{
    public class ArrayLists
    {
        public static void Execute(){

            //METODO DE AUXILIO PARA EXIBIR OS ITEMS
            static void exibirArrayList(ArrayList lista ){
                //USO DE COUNT PARA OBTER O TAMANHO DA LISTA
                Console.WriteLine($"Tamanho do array list: {lista.Count}");                
                foreach(var item in lista) {
                    //BUSCA PELO INDICE DA PRIMEIRA INSTACIA DE UM OBJETO IGUAL A ESTE PRESENTE NA LISTA
                    var indiceItemPrimeiraInstancia = lista.IndexOf(item);
                    //BUSCA PELO INDICE DA ULTIMA INSTACIA DE UM OBJETO IGUAL A ESTE PRESENTE NA LISTA
                    var indiceItemUltimaInstancia = lista.LastIndexOf(item);
                    Console.WriteLine($"Posicao 1ª instancia: {indiceItemPrimeiraInstancia} - ultima: {indiceItemUltimaInstancia} | {item.ToString()} => {item.GetType()}");                    
                }
            }

            //HETEROGENEO TIPOS DE DADOS VARIADOS | INDEXADO
            var arrayList = new ArrayList {
                'c',
                "STRINGGIGANTE AQUI",
                768745689,
                true
            };
            double valorAleatorio = 345.656;
            double valorAleatorio2 = valorAleatorio;
            arrayList.Add(valorAleatorio);
            arrayList.Add(valorAleatorio2);
            arrayList.Add(valorAleatorio2);
            arrayList.Add(valorAleatorio);
            exibirArrayList(arrayList);

        }
    }
}