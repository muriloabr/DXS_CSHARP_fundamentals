using System;
using System.Collections.Generic;
//BIBLIOTECA LikedINtegratedQuery POSSUI METODOS DE EXTENSAO QUE AJUDAM NA MANIPULACAO DE LISTAS
using System.Linq;

namespace DXS_CSHARP_fundamentals.AdvancedTopics
{
    internal class Linqs
    {
        public class Aluno {
            public string Nome { get; set; }
            public int Idade { get; set;}
            public double Nota { get; set;}    
        }
        public static void Execute()
        {
            static void ExibirLista(List<Aluno> lista)
            {
                Console.WriteLine($"== CLASSE COM: {lista.Count} Alunos Aprovados ==");
                foreach (Aluno aluninho in lista)
                {
                    Console.WriteLine(aluninho.Nome);
                }
                Console.WriteLine("=========================");
            }
            var classe = new List<Aluno>()
            {
                new Aluno { Nome = "Pedro", Idade = 19, Nota = 8.4 },
                new Aluno {Nome = "Kelly", Idade = 21, Nota = 9.8 },
                new Aluno {Nome = "Pedro", Idade = 20, Nota = 7.0 },
                new Aluno {Nome = "Zozimo", Idade = 23, Nota = 4.6 },
                new Aluno {Nome = "Ana", Idade = 26, Nota = 8.2 },
                new Aluno {Nome = "Juarez", Idade = 27, Nota = 5.2 },
                new Aluno {Nome = "Fernando", Idade = 23, Nota = 3.6 },
            };
            
            //FUNCAO LINQ RECEBE LAMBDA COMO PARAMETRO PARA FILTRAGEM DOS ITENS
            //var aprovados = classe.Where( a => true ); //SEMPRE TRUE PARA TODOS ITEMS
            //var aprovados = classe.Where(a => a.Nota >= 7.1).OrderBy( a => - a.Nota ); //NOTA DE CORTE 7.1 ORDENADO POR NOTA MAIOR PARA MENOR [PORQUE ESTA TRANSFORMANDO EM VALORES NEGATIVOS -]
            var aprovados = classe.Where(a => a.Nota >= 7.1).OrderBy( a => + a.Nota ); //NOTA DE CORTE 7.1 ORDENADO POR NOTA MENOR PARA MAIOR COMO NATURALMENTE FAZ
            
            Console.WriteLine($"== CLASSE COM: {aprovados.Count()} Alunos Aprovados na provinha ==");
            foreach (Aluno aluninho in aprovados)
            {
                Console.WriteLine(aluninho.Nome);
            }
            Console.WriteLine("=========================");

            //TRANSFORMAR LISTA DE OBJETOS EM LISTA DE TEXTOS [MAP]
            var listaChamada = classe.OrderBy(a => a.Nome).Select(a => a.Nome);
            
            Console.WriteLine($"== CLASSE COM: {listaChamada.Count()} Alunos na chamada ==");
            foreach (string aluninho in listaChamada)
            {
                Console.WriteLine(aluninho);
            }
            Console.WriteLine("=========================");

            //RESULTA NUMA LISTA COM O TIPO IDENTIFICADO EM SELECT
            var alunosAprovados = 
                from aluno in classe
                where aluno.Nota >= 5.0
                orderby - aluno.Idade 
                select aluno.Nome; //TIPO DO RESULTADO

            Console.WriteLine($"== CLASSE COM: {alunosAprovados.Count()} Alunos que foram aprovados ==");
            foreach (string aluninho in alunosAprovados)
            {
                Console.WriteLine(aluninho);
            }
            Console.WriteLine("=========================");

            //CAPTURANDO UM UNICO RESULTADO
            var alunoX = classe.SingleOrDefault(aluno => aluno.Nome.Equals("Fernando"));
            if (alunoX!=null) { Console.WriteLine("ALUNO: " + alunoX.Nome); } else { Console.WriteLine("ALUNO INEXISTENTE"); }

            alunoX = classe.FirstOrDefault(aluno => aluno.Nome.Equals("Pedro"));
            if (alunoX != null) { Console.WriteLine("ALUNO: " + alunoX.Nome); } else { Console.WriteLine("ALUNO INEXISTENTE"); }

            //CAPTURANDO UMA PORCAO DELES
            var alunoXMenosOsprimeiros = classe.Skip(2).Take(3);
            Console.WriteLine($"== CLASSE COM: {alunoXMenosOsprimeiros.Count()} Alunos do fundao ==");
            foreach (Aluno aluninho in alunoXMenosOsprimeiros)
            {
                Console.WriteLine(aluninho.Nome);
            }
            Console.WriteLine("=========================");
        }
    }
}
