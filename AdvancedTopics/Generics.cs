using System;
using System.Collections.Generic;
using DXS_CSHARP_fundamentals.MethodsAndClasses;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXS_CSHARP_fundamentals.AdvancedTopics
{
    //CLASSE GENERICA
    public class CaixaObscura<TANTO, FAZ>
    {
        FAZ dado2privado;
        public TANTO Dado1 { get; set; }
        public FAZ Dado2 { get; set; }

        public CaixaObscura(TANTO dado1, FAZ dado2)
        {
            Dado1 = dado1;
            Dado2 = dado2;
            dado2privado = dado2;   
        }
        
        public string MetodoGenerico(TANTO valor1, FAZ valor2) {
            return valor1.ToString() + valor2.ToString();
        }

        public FAZ MetodoGetvalorFaz (){
            return dado2privado;
        }
    }

    class Caixa : CaixaObscura<int, double>
    {
        public Caixa() : base(500, 250.5) {}
    }

    class CaixaPessoa: CaixaObscura<int ,Pessoa_object>
    {
        public CaixaPessoa(int valor1, Pessoa_object valor2) : base(valor1, valor2) { }
    }

    internal class Generics
    {
        public static void Execute()
        {
            var caixa = new Caixa();
            Console.WriteLine("VALOR: " + caixa.MetodoGetvalorFaz());
            Console.WriteLine("VALOR: " + caixa.MetodoGetvalorFaz());

            var caixa2 = new CaixaObscura<int, string>(123, "textoEscrito");
            Console.WriteLine("VALOR: " + caixa2.MetodoGetvalorFaz());
            Console.WriteLine("VALOR: " + caixa2.MetodoGetvalorFaz());

            CaixaPessoa caixa3 = new CaixaPessoa(125, new Pessoa_object("Juarez", 45));
            Console.WriteLine("VALOR: " + caixa3.MetodoGetvalorFaz().Nome);
        }
    }
}
