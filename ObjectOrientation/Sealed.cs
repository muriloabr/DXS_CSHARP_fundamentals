using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXS_CSHARP_fundamentals.ObjectOrientation
{
    sealed class NaoPodeSerHerdada {
        public string Informacao()
        {
            return "Sou Sealed, não posso ser herdada!";
        }
    }
    //CLASSE SEALED NAO PODE SER HERDADA
    //class QueroHerdar: NaoPodeSerHerdada {}
    class Informacao
    {
        private string Info = "Amanhã começa as férias coletivas!";
        public virtual string Falar() { return Info; }
    }
    class Chefe: Informacao {
        public override sealed string Falar()
        {
            return "Opa depois de " + base.Falar().ToLower(); 
        }
    }
    class Gerente : Chefe {
        /*METODO SEALED NAO PODE SER SOBRESCRITO
        public override string Falar()
        {
            return "Mês que vem só e não " + base.ToString().ToLower();
        }
        */
        //METODO EM MODO DE OCULTACAO FUNCIONA!
        public new string Falar()
        {
            return "É no mês que vem só e não " + base.Falar().ToLower();
        }
    }

    internal class Sealed
    {
        public static void Execute()
        {
            Gerente gerente = new Gerente();
            Console.WriteLine(gerente.Falar());
            Chefe chefePromovido = gerente;
            Console.WriteLine(chefePromovido.Falar());
        }
    }
}
