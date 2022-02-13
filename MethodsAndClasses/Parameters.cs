using System;

namespace DXS_CSHARP_fundamentals.MethodsAndClasses
{
    public class Parameters
    {
        //USO DE PARAMS RECEPCIONANDO INCONTÁVEIS VALORES STRINGS
        public static void Recepcionar(params string[] pessoas){
           foreach(var pessoa in pessoas){
               Console.WriteLine($"Olá {pessoa}");               
           } 
        }

        //PARAMETROS NOMEADOS
        public static void Formatar(int dia, int mes, int ano){
            Console.WriteLine("{0:D2}/{1:D2}/{2}", dia, mes, ano);            
        }

       public static void Execute(){
           //ENVIANDO INCONTÁVEIS VALORES STRINGS POR PARAMETRO
           Recepcionar("Juarez", "Marco Antonio", "Soberando Palhares", "González Dias", "Pedro Alcantara");
           //ENVIANDO PARAMETROS NOMEADOS
           Formatar(ano:1995, dia:3,mes:2);
       }
    }
}