using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DXS_CSHARP_fundamentals.AdvancedTopics
{
    internal class Dynamics
    {
        public static void Execute()
        {
            //TIPO DYNAMIC PODE RECEBER QUALQUER TIPO DE OBJETO E DADO
            dynamic objeto = 1234125.56f;
            objeto = new List<string> { "Joao", "Rodrigao", "Juarez" };
            objeto.Add("Bernado");
            objeto = new Char();
            objeto += 'c';
            objeto *= 2;
            Console.WriteLine(objeto);
            objeto = new System.Dynamic.ExpandoObject();
            objeto.nome = "Juarez el Donatto";
            objeto.notaProva = 8.74;
            objeto.idade = 34;
            Console.WriteLine($"NOME: {objeto.nome} | NOTA: {objeto.notaProva} | IDADE: {objeto.idade}");
        }
    }
}
