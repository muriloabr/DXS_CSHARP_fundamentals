using System;
using System.Collections.Generic;

namespace DXS_CSHARP_fundamentals.Collections
{
    public class Dictionaries
    {
        public static void Execute(){
            //DICTIONARY É UMA ESTRUTURA DE CHAVE E VALOR, ACEITANDO DUPLICATAS NO VALOR, MAS NÃO NA CHAVE
            var filmes = new Dictionary<int, string>();
            filmes.Add(2012, "Spyderman: amazing");
            filmes.Add(2022, "Spyderman: no way home");
            filmes.Add(2021, "Spyderman: back to home");
            //METODO INSEGURO PARA OBTENÇÃO DE VALOR POR CHAVE + CONTAINSKEY BUSCA POR CHAVE NO DICTIONARY
            Console.WriteLine($"Tem o do ano 2012? : {filmes.ContainsKey(2012)} : {filmes[2012]}");
            //METODO MAIS SEGURO PARA OBTENÇÃO DE VALOR POR CHAVE
            Console.WriteLine($" e o do ano 2016? : {filmes.ContainsKey(2016)} : {filmes.GetValueOrDefault(2016)}");            
            Console.WriteLine($" e aquele tal de no way home? : {filmes.ContainsValue("Spyderman: no way home")}");
            Console.WriteLine($"Consegue jogar fora o do ano de 2012? : {filmes.Remove(2012)}");
            Console.WriteLine($"tem outro para jogar fora do ano de 2012? : {filmes.Remove(2012)}");
            //METODO SEGURO PARA OBTENÇÃO DE VALOR POR CHAVE
            filmes.TryGetValue(2021, out string nomeDoFilme);
            Console.WriteLine($"Tinha esquecido desse de 2021: {nomeDoFilme}");
            filmes.TryGetValue(2018, out nomeDoFilme);
            Console.WriteLine($"e esqueci desse de 2018: {nomeDoFilme}");
            
            //METODO EXPLICITO POR CHAVES
            foreach(var chave in filmes.Keys){
                Console.WriteLine($"Tem esse de {chave}");                
            }
            //METODO EXPLICITO POR VALORES
            foreach(var valor in filmes.Values){
                Console.WriteLine($"Que é esse : {valor}");                
            }
            //METODO EXPLICITO CHAVEVALOR PAIR
            foreach(KeyValuePair<int, string> par in filmes){
                Console.WriteLine($"Do ano : {par.Key} de nome : {par.Value}");                
            }
             //METODO IMPLICITO PELO TIPO DE VARIAVEL CONSTRUIDA <int, string>
            foreach(var filme in filmes){
                Console.WriteLine($"Titulo : {filme.Value} do ano : {filme.Key}");                
            }
        }
 
    }
}