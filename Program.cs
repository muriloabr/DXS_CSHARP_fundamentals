using System;
using System.Collections.Generic;
//IMPORTING CLASSES
using DXS_CSHARP_fundamentals.Fundamentals;
using DXS_CSHARP_fundamentals.ControlStructures;
using DXS_CSHARP_fundamentals.MethodsAndClasses;

namespace DXS_CSHARP_fundamentals {
    class Program {
        static void Main(string[] args) {
            //REGISTRO TODO OS MEUS EXEMPLOS JÁ CRIADOS!
            var allExercices = new ExamplesController(new Dictionary<string, Action>() {
                // Fundamentals
                {"Variables and Constants", VariablesAndConstants.Execute},
                {"Interpolation and Dot Notation", InterpolationDotNotation.Execute},
                {"Read, Write and Compare Values", ReadWriteAndCompareValues.Execute},
                // Control Structures
                {"Methods And Classes", MethodsAndClasses.Execute},
                {"Structures", Structures.Execute},
            });
            //INCIO O SISTEMA DE ESCOLHA PARA RODAR O EXEMPLO QUE VAI SER ESCOLHIDO!
            allExercices.SelectAndExecuteTheExample();
        }
    }
}