using System;
using System.Collections.Generic;
using DXS_CSHARP_fundamentals.Fundamentals;

namespace DXS_CSHARP_fundamentals {
    class Program {
        static void Main(string[] args) {
            //REGISTRO TODO OS MEUS EXEMPLOS JÁ CRIADOS!
            var allExercices = new ExamplesController(new Dictionary<string, Action>() {
                // Fundamentals | First
                {"Variables and Constants", VariablesAndConstants.Execute},
                {"Segundo Programa - Comments", Comments.Execute},
            });
            //INCIO O SISTEMA DE ESCOLHA PARA RODAR O EXEMPLO QUE VAI SER ESCOLHIDO!
            allExercices.SelectAndExecuteTheExample();
        }
    }
}