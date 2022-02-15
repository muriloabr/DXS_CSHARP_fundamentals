using System;
using System.IO;

namespace DXS_CSHARP_fundamentals.API
{
    internal class ReadingAndWritingDirectories
    {
        private static void LerDadosDoDiretorio(string caminho)
        {
            var directorioInformacao = new DirectoryInfo(caminho);
            //USANDO AGORA A FUNCAO .EXISTS DE INSTANCIA
            if (directorioInformacao.Exists)
            { 
                Console.WriteLine("LENDO PASTA: " + directorioInformacao.Name);
                Console.WriteLine("==== ARQUIVOS ====");
                foreach (var dr in directorioInformacao.GetDirectories())
                {
                    Console.WriteLine(dr);
                }
                foreach (var dr in directorioInformacao.GetFiles())
                {
                    Console.WriteLine(dr);
                }
                //DOTNOTATION ENCADEADA COM METODOS DE RETURN DE MESMO OBJETO
                Console.WriteLine(directorioInformacao?.Parent.Parent.Parent);
                Console.WriteLine(directorioInformacao?.Root);
                Console.WriteLine(directorioInformacao?.CreationTime);

                //USO DO PATH PARA LER DADOS
                Console.WriteLine("Nome da Pasta em que está: " + Path.GetDirectoryName(caminho) + "");
                Console.WriteLine("Nome limpo: " + Path.GetFileNameWithoutExtension(caminho) + "");
                Console.WriteLine("Tem Extensão definida? : " + Path.HasExtension(caminho) + "");
                Console.WriteLine("Raiz : " + Path.GetPathRoot(caminho) + "");
            }
            else
            {
                Console.WriteLine("NAO EXISTE A PASTA PARA LER OS DADOS");
            }
        }
        private static void MoverDiretorio(string caminho, string moverParacaminho)
        {
            if (Directory.Exists(caminho))
            {
                Console.WriteLine("MOVENDO PARA: " + moverParacaminho);
                Directory.Move(caminho, moverParacaminho);
            }
            else
            {
                Console.WriteLine("NAO EXISTE A PASTA PARA MOVER");
            }
        }
        private static void LerARaizDoDiretorio(string caminho)
        {
            if (Directory.Exists(caminho))
            {
                Console.WriteLine("======= RAIZ =======");
                foreach (var dr in Directory.GetDirectoryRoot(caminho))
                {
                    Console.WriteLine(dr);
                }
            }
        }
        private static void LerDiretorio(string caminho)
        {
            if (Directory.Exists(caminho))
            {
                Console.WriteLine("== PASTAS ==");
                foreach(var dr in Directory.GetDirectories(caminho))
                {
                    Console.WriteLine(dr);
                }
            }
        }
        private static void LerArquivosDoDiretorio(string caminho)
        {
            if (Directory.Exists(caminho))
            {
                Console.WriteLine("==== ARQUIVOS ====");
                foreach (var dr in Directory.GetFiles(caminho))
                {
                    Console.WriteLine(dr);
                }
            }
        }
        private static void ApagarUmaPasta(string caminho)
        {            
            try
            {
                if (Directory.Exists(caminho))
                {
                    Console.WriteLine("APAGANDO: " + caminho);
                    //DELEÇÃO DE FORMA RECURSIVA SE FOR PASTA CHEIA
                    Directory.Delete(caminho, true);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("DEU ERRO AO DELETAR: " + ex.Message);
            }
        }
        private static bool CriarUmaPasta(string caminho)
        {
            try
            {
                if (!Directory.Exists(caminho))
                {
                    Console.WriteLine("CRIANDO PASTA: " + caminho);
                    Directory.CreateDirectory(caminho);
                    return true;
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("DEU ERRO AO DELETAR: " + ex.Message);
                return false;
            }
            return false;
        }
        public static void Execute()
        {
            var raiz = @"~/".TransformarCaminho();
            var caminho = @"~/PastaCustomizada".TransformarCaminho();
            var moverParaCaminho = @"~/PastaCustomizadaMovida".TransformarCaminho();
            //REMOVENDO PASTAS SE EXISTIREM
            ApagarUmaPasta(caminho);
            ApagarUmaPasta(moverParaCaminho);
            //CRIANDO PASTAS
            CriarUmaPasta(caminho);
            //LENDO AS PASTAS NO DIRETORIO PASSADO
            LerDiretorio(raiz);
            //LENDO OS ARQUIVOS O DIRETORIO PASSADO
            LerArquivosDoDiretorio(raiz);
            //LENDO O CAMINHO RAIZ DO DIRETORIO PASSADO
            LerARaizDoDiretorio(raiz);
            MoverDiretorio(caminho, moverParaCaminho);
            LerDadosDoDiretorio(moverParaCaminho);
            ApagarUmaPasta(moverParaCaminho);
        }
    }
}
