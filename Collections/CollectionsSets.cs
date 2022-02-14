using System;
using System.Collections.Generic;
namespace DXS_CSHARP_fundamentals.Collections
{
    public class CollectionsSets
    {
        public static void Execute(){
            //METODO DE AUXILIO PARA EXIBIR OS ITEMS
            static void exibirHashSet(HashSet<Produto> lista ){
                //USO DE COUNT PARA OBTER O TAMANHO DO HashSet
                Console.WriteLine($"Tamanho do HashSet: {lista.Count}");                
                foreach(var item in lista) {
                    Console.WriteLine($"nome: {item.Nome} - preço: {item.Preco.ToString("C2")}");                    
                }
            }
            var livrao = new Produto("O mestre do ar", 144.99);
            //HashSet POSSUI TAMANHO VARIAVEL E NÃO É INDEXADO E NAO ACEITA DUPLICATAS
            //INSTANCIANDO HashSet COM ITEMS NA CONSTRUÇÃO
            var combaoPromo01 = new HashSet<Produto> {
                new Produto("Radio book", 12.99),
                new Produto("Miniatura Golden Fish", 58.99),
                new Produto("Livrobook", 42.99),
                new Produto("Caneta comemorativa", 2.99)
            };
            //INSTANCIANDO HashSet VAZIO 
            var carrinhoCompras = new HashSet<Produto>();
            //METODO PARA ADICIONAR UM UNICO ITEM
            carrinhoCompras.Add(livrao);
            //METODO PARA ADICIONAR OS ITEMS DE OUTRO HashSet PARA DENTRO DESTE
            carrinhoCompras.UnionWith(combaoPromo01);            
            //MESMA REFERENCIA DE OBJETOS ENTAO A MUDANÇA ALTERA O OBJETO NAS DUAS LISTAS          
            //combaoPromo01[0].Nome = "Book especial";
            //HashSet NÃO ACEITA ADIÇÃO DE ELEMENTOS IGUAIS
            carrinhoCompras.Add(livrao);
            carrinhoCompras.Add(livrao);
            carrinhoCompras.Add(livrao);          
            exibirHashSet(carrinhoCompras);
            //METODO PARA REMOVER UM ITEM CASO EXISTIR
            carrinhoCompras.Remove(livrao);
            carrinhoCompras.Remove(livrao);
            exibirHashSet(carrinhoCompras);
        }
    }
}