using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXS_CSHARP_fundamentals.AdvancedTopics
{
    public class CaixaObscura<TANTO, FAZ>
    {
        TANTO valorTanto;
        FAZ valorFaz;
        public TANTO Dado1 { get; set; }
        public FAZ Dado2 { get; set; }

        public CaixaObscura(TANTO dado1, FAZ dado2)
        {
            Dado1 = dado1;
            Dado2 = dado2;  
        }
    }
    internal class Generics
    {
        public static void Execute()
        {
        }
    }
}
