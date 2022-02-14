using System;
using DXS_CSHARP_encapsulation;

namespace DXS_CSHARP_fundamentals.ObjectOrientation
{
    public class AbandonedSonsOfSubCelebrity: SubCelebrity
    {
        public new void TudoSobreMim()
        {
            Console.WriteLine("COISAS QUE EU AbandonedSonsOfSubCelebrity POSSO REVELAR DA MINHA MÃE CRUEL SubCelebrity!");
            //ATRIBUTO PRIVADO NÃO PODE SER ACESSADO NEM PELA HERANÇA DIRETA
            //Console.WriteLine(UsaMuitoCorrecaoEmFoto);
            //PRIVATE PROTECTED - SOMENTE PODE SER ACESSADO POR HERANÇA DIRETA E DENTRO DO MESMO PROJETO
            //Console.WriteLine(SegredoDeFamilia);
            Console.WriteLine(JeitoDeFalar);
            //INTERNAL SÓ PODE SER ACESSADO POR QUEM ESTÁ DENTRO DO MESMO PROJETO [ASSEMBLY]
            //Console.WriteLine(NumeroCelular);
            Console.WriteLine(CorDoOlho);
            Console.WriteLine(InfoPublica);
        }
    }
    public class FarAwayFriendOfSubCelebrity
    {
        public readonly SubCelebrity amiga = new SubCelebrity();

        public void TudoSobreMim()
        {
            Console.WriteLine("COISAS QUE EU FriendOfSubCelebrity POSSO REVELAR DA SubCelebrity!");
            //ATRIBUTO PRIVADO NÃO PODE SER ACESSADO NEM PELA HERANÇA DIRETA
            //Console.WriteLine(UsaMuitoCorrecaoEmFoto);
            //PRIVATE PROTECTED - SOMENTE PODE SER ACESSADO POR HERANÇA DIRETA E DENTRO DO MESMO PROJETO
            //Console.WriteLine(amiga.SegredoDeFamilia);
            //PROTECTED INTERNAL - SOMENTE QUEM ESTIVER NO MESMO PROJETO OU TIVER HERANÇA DIRETA TERÁ ACESSO
            //Console.WriteLine(amiga.JeitoDeFalar);
            //INTERNAL SÓ PODE SER ACESSADO POR QUEM ESTÁ DENTRO DO MESMO PROJETO [ASSEMBLY]
            //Console.WriteLine(amiga.NumeroCelular);
            //PROTECTED SOMENTE PODE SER ACESSADO POR HERANÇA DIRETA
            //Console.WriteLine(amiga.CorDoOlho);
            Console.WriteLine(amiga.InfoPublica);
        }
    }
    class Encapsulation
    {
        public static void Execute()
        {
            new SubCelebrity().TudoSobreMim();
            new SonOfCelebrity().TudoSobreMim();
            new FriendOfSubCelebrity().TudoSobreMim();
            new AbandonedSonsOfSubCelebrity().TudoSobreMim();
            new FarAwayFriendOfSubCelebrity().TudoSobreMim();
        }
    }
}
