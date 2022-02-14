using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXS_CSHARP_fundamentals.ObjectOrientation
{
    //CLASSE ABSTRATA É UMA CLASSE INACABADA QUE NAO PODE SER INSTANCIADA
    //PODE TER TODOS OS METODOS IMPLEMENTADOS OU NAO
    //FICA A CARGO DA REGRA DE HERANÇA: SOMENTE SENDO POSSIVEL UMA CLASSE HERDAR OUTRA UNICA CLASSE
    public abstract class Celular {
        //METODO ABSTRATO QUE SERA NECESSARIO QUEM HERDAR IMPLEMENTAR ELE
        public abstract string AssistenteVirtual();
        //METODO IMPLEMENTADO
        public string Tocar()
        {
            return "ti li limmm";
        }
    }

    public class Samsung : Celular {
        public override string AssistenteVirtual()
        {
            return "Olá, sou Bixby!";
        }
    }

    public class Iphone : Celular
    {        public override string AssistenteVirtual()
        {
            return "Olá, sou Siri!";
        }
    }

    internal class Abstract
    {
        public static void Execute()
        {
            var listaCelulares = new List<Celular> {
                new Iphone(),
                new Samsung()
            };
            foreach (var celular in listaCelulares) {
                Console.WriteLine(celular.AssistenteVirtual());
            }   
        }
    }
}
