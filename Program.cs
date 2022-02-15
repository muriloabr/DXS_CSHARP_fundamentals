using System;
using System.Collections.Generic;
//IMPORTING CLASSES
using DXS_CSHARP_fundamentals.Fundamentals;
using DXS_CSHARP_fundamentals.ControlStructures;
using DXS_CSHARP_fundamentals.MethodsAndClasses;
using DXS_CSHARP_fundamentals.Collections;
using DXS_CSHARP_fundamentals.ObjectOrientation;
using DXS_CSHARP_fundamentals.MethodsAndFunctions;
using DXS_CSHARP_fundamentals.Exceptions;
using DXS_CSHARP_fundamentals.API;
using DXS_CSHARP_fundamentals.AdvancedTopics;

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
                {"Structures", Structures.Execute},
                //Methods and Classes
                {"Methods And Classes", Members.Execute},
                {"Methods", Methods.Execute},               
                {"Get and Seters", GetSet.Execute},
                {"Read only", ConstantsAndReadonly.Execute},
                {"Enumerators", Enumerators.Execute},
                {"Structs", ClassVsStructs.Execute},
                {"Parameters", Parameters.Execute},
                //Collections
                {"Arrays", Collections.Arrays.Execute},
                {"Lists", Collections.Lists.Execute},
                {"ArrayLists", Collections.ArrayLists.Execute},
                {"Collections Sets", CollectionsSets.Execute},
                {"Queues", Queues.Execute},
                {"Collections Comparators", Comparators.Execute},
                {"Stacks", Stacks.Execute},
                {"Dictionaries", Dictionaries.Execute},
                //Objetc Orientation
                {"Object Inheritance", ObjectInheritance.Execute},
                {"Object Constructors", Constructors.Execute},
                {"Object Encapsulation", Encapsulation.Execute},
                {"Object Polymorphism", Polymorphism.Execute},
                {"Abstract Classes", Abstract.Execute},
                {"Interface Classes", Interface.Execute},                
                {"Sealed", Sealed.Execute},
                //Methods And Functions
                {"Lambda", Lambda.Execute},
                {"Delegate", MethodsAndFunctions.Delegate.Execute},
                {"Extension Methods", ExtensionMethods.Execute},
                //Exceptions
                {"Exception Handling", ExceptionHandling.Execute},
                //API
                {"Reading and Writing Files", ReadingAndWritingFiles.Execute},
                {"Reading and Writing Directories", ReadingAndWritingDirectories.Execute},
                {"DateTimes and TimesPan", DateTimesAndTimesPan.Execute},
                //Advanced Topics
                {"Linqs", Linqs.Execute},
                {"Nullables", Nullables.Execute},
                {"Dynamics", Dynamics.Execute},
                {"Generics", Generics.Execute},                
            });
            //INCIO O SISTEMA DE ESCOLHA PARA RODAR O EXEMPLO QUE VAI SER ESCOLHIDO!
            allExercices.SelectAndExecuteTheExample();
        }
    }
}