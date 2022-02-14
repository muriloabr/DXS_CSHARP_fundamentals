using System;
using System.Collections.Generic;
namespace DXS_CSHARP_fundamentals.Collections
{
    public class Produto {
        public string Nome;
        public double Preco;

        public Produto(string nome, double preco) {
            Nome = nome;
            Preco = preco;
        }
    }
    public class Lists
    {
        public static void Execute(){
            //METODO DE AUXILIO PARA EXIBIR OS ITEMS
            static void exibirList(List<Produto> lista ){
                //USO DE COUNT PARA OBTER O TAMANHO DA LISTA
                Console.WriteLine($"Tamanho da lista: {lista.Count}");                
                foreach(var item in lista) {
                    //BUSCA PELO INDICE DA PRIMEIRA INSTACIA DE UM OBJETO IGUAL A ESTE PRESENTE NA LISTA
                    var indiceItemPrimeiraInstancia = lista.IndexOf(item);
                    //BUSCA PELO INDICE DA ULTIMA INSTACIA DE UM OBJETO IGUAL A ESTE PRESENTE NA LISTA
                    var indiceItemUltimaInstancia = lista.LastIndexOf(item);
                    Console.WriteLine($"Posicao 1ª instancia: {indiceItemPrimeiraInstancia} - ultima instancia: {indiceItemUltimaInstancia} | nome: {item.Nome} - preço: {item.Preco.ToString("C2")}");                    
                }
            }
            var livrao = new Produto("O mestre do ar", 144.99);
            //LIST POSSUI TAMANHO VARIAVEL E É INDEXADA
            //INSTANCIANDO LISTA COM ITEMS NA CONSTRUÇÃO
            var combaoPromo01 = new List<Produto> {
                new Produto("Radio book", 12.99),
                new Produto("Miniatura Golden Fish", 58.99),
                new Produto("Livrobook", 42.99),
                new Produto("Caneta comemorativa", 2.99)
            };
            //INSTANCIANDO LISTA VAZIA
            var carrinhoCompras = new List<Produto>();
            //METODO PARA ADICIONAR UM UNICO ITEM
            carrinhoCompras.Add(livrao);
            //METODO PARA ADICIONAR OS ITEMS DE OUTRA LISTA PARA DENTRO DESTA
            carrinhoCompras.AddRange(combaoPromo01);            
            //MESMA REFERENCIA DE OBJETOS ENTAO A MUDANÇA ALTERA O OBJETO NAS DUAS LISTAS          
            combaoPromo01[0].Nome = "Book especial";
            //LIST ACEITA ADIÇÃO DE ELEMENTOS IGUAIS
            carrinhoCompras.Add(livrao);
            carrinhoCompras.Add(livrao);
            carrinhoCompras.Add(livrao); 
            carrinhoCompras.Add(livrao);
            carrinhoCompras.Add(carrinhoCompras[3]);
            carrinhoCompras.Add(livrao);          
            exibirList(carrinhoCompras);
            Console.WriteLine($"Primeiro item do Combão puro: {combaoPromo01[0].Nome} | O mesmo item no carrinho: {carrinhoCompras[1].Nome}");
            //METODO PARA REMOVER O ITEM DO INDICE ESCOLHIDO
            carrinhoCompras.RemoveAt(2);
            exibirList(carrinhoCompras);
            //METODO PARA REMOVER O ITEM POR ORDEM CRESCENTE DE INDICE CASO EXISTIR
            carrinhoCompras.Remove(livrao);
            carrinhoCompras.Remove(livrao);
            carrinhoCompras.Remove(livrao);
            carrinhoCompras.Remove(livrao);
            carrinhoCompras.Remove(livrao);
            carrinhoCompras.Remove(livrao);
            carrinhoCompras.Remove(livrao);
            carrinhoCompras.Remove(livrao);
            exibirList(carrinhoCompras);
            //METODO PARA REMOVER UM RANGE A PARTIR DE UM INDICE
            carrinhoCompras.RemoveRange(2,2);  
            exibirList(carrinhoCompras);
        }
    }
}