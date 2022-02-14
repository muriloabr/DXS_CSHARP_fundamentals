using System;

namespace DXS_CSHARP_fundamentals.Collections
{
    public class Arrays
    {
        public static void Execute(){
            //ARRAY = ESTRUTURA HOMOGENEA = TIPO FIXO DE ELEMENTOS CONFORME INSTANCIADO
            //TAMANHO FIXO PRE DEFINIDO CONFORME INSTANCIADO
            //INDEXADA POR TER ACESSO POR INDICE
            string[] _alunos1 = new string[5];
            //ATRIBUIÇÃO SIMPLES
            _alunos1[0] = "Eeemanuel";
            _alunos1[4] = "Kalaam";
            _alunos1[1] = "Juarez";
            _alunos1[3] = "Joana";
            _alunos1[2] = "Kamilly";

            string [] _alunos2 = {
                "Joana",
                "Juarez",
                "Kamilly",
                "Gutemberg",
                "Eeemanuel",
                "Hermanotheu",
                "Kalaam"
            };

            Console.WriteLine($"SERIE A COM {_alunos1.Length} alunos:");            
            //METODOS DE RECUPERACAO DE VALOR
            foreach(var aluno in _alunos1){
                Console.WriteLine($"Aluno: {aluno}");                
            }
            Console.WriteLine($"SERIE B COM {_alunos2.Length} alunos:");    
            for(int i  =0; i < _alunos2.Length; i++){
                Console.WriteLine($"Aluno: {_alunos2[i]}");                
            }
            char[] letras = {'A','L','U','N','O','S'};
            Console.WriteLine($"{new string(letras)}");            
        }
    }
}