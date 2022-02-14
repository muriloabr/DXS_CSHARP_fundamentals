using System;
using System.IO;

namespace DXS_CSHARP_fundamentals.API
{
    //CLASSE EXCLUSIVA PARA CRIACAO DOS METODOS DE EXTENSAO CUSTOMIZADOS PARA STRING
    public static class ExtensaoParaString
    {
        //METODO DE EXTENSAO DE ESTRING QUE FORMATA O CAMINHO COLOCANDO O PATH COMPLETO NO LUGAR DE '~'
        public static string TransformarCaminho(this string caminho)
        {
            string caminhoPorComputador = (Environment.OSVersion.Platform == PlatformID.Unix || Environment.OSVersion.Platform == PlatformID.Other) ? Environment.GetEnvironmentVariable("HOME") : Environment.ExpandEnvironmentVariables("%HOMEDRIVE%%HOMEPATH%");
            return caminho.Replace("~", caminhoPorComputador);
        }
    }

    internal class ReadingAndWritingFiles
    {
        private static void ApagarTodosArquivoSimples(params string[] caminhos)
        {
            foreach (var caminho in caminhos) {
                try
                {
                    if (File.Exists(caminho))
                    {
                        FileInfo informacao = new FileInfo(caminho);
                        Console.WriteLine("APAGANDO: " + informacao.Name);
                        informacao.Delete();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("DEU ERRO AO DELETAR: " + ex.Message);
                }
            }
        }
        private static bool MoverArquivoSimples(string caminhoArquivo_usado, string novoCaminhoArquivo_usado)
        {
            try
            {
                if (File.Exists(caminhoArquivo_usado))
                {
                    FileInfo informacao = new FileInfo(caminhoArquivo_usado);
                    informacao.MoveTo(novoCaminhoArquivo_usado);
                    return true;
                }
                return false;
            } catch (Exception ex)
            {
                return false;
            }
        }

        private static bool CopiarArquivoSimples(string caminhoArquivo_usado, string novoCaminhoArquivo_usado)
        {
            try
            {
                if (File.Exists(caminhoArquivo_usado))
                {
                    FileInfo informacao = new FileInfo(caminhoArquivo_usado);
                    informacao.CopyTo(novoCaminhoArquivo_usado);
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        private static string LerDadosArquivoSimples(string caminhoArquivo_usado)
        {
            var dados = "NADA CONSTA";
            if (File.Exists(caminhoArquivo_usado))
            {
                FileInfo informacao = new FileInfo(caminhoArquivo_usado);
                dados = "Arquivo: " + informacao.Name + "\n";
                dados += "ReadOnly: " + informacao.IsReadOnly + "\n";
                dados += "Path : " + informacao.FullName + "\n";
                dados += "Extensão: " + informacao.Extension + "\n";
            }
            return dados;
        }
            private static string LerArquivoSimples(string caminhoArquivo_usado)
        {
            var dadosDoArquivo = "NADA CONSTA";
            caminhoArquivo_usado = caminhoArquivo_usado.TransformarCaminho();
            if (File.Exists(caminhoArquivo_usado))
            {
                try
                {
                    using (StreamReader sr = new StreamReader(caminhoArquivo_usado))
                    {
                        dadosDoArquivo = sr.ReadToEnd();
                        Console.WriteLine(dadosDoArquivo);
                        return dadosDoArquivo;
                    }
                } catch (Exception ex)
                {
                    dadosDoArquivo = ex.Message;
                    return dadosDoArquivo;
                }
            }
            else
            {
                dadosDoArquivo = "NAO ACHOU O ARQUIVO!";
                return dadosDoArquivo;
            }
        }

        private static string EscreverArquivoSimples(string caminhoArquivo_usado)
        {
            caminhoArquivo_usado = caminhoArquivo_usado.TransformarCaminho();
            //USANDO O METODO DE EXTENSAO DA CLASSE STATIC ACIMA

            //SE O ARQUIVO NAO EXISTE ELE CRIA E ESCREVE
            if (!File.Exists(caminhoArquivo_usado))
            {
                //using = PARA O CSHARP LIMPAR O BLOCO COM TODAS AS DLLS E CHAMADAS QUE REQUEREM PARA TRABALHAR COM ARQUIVOS APÓS O USO | DESALOCAO DE RECURSO
                //DENTRO DO PARENTESES DE USING DEVE CONTER UM ELEMENTO QUE IMPLEMENTA A INTERFACE IDisposable PARA EFETUAR ESSA LIMPEZA
                using (StreamWriter sw = File.CreateText(caminhoArquivo_usado))
                {
                    sw.WriteLine("arquivo sendo");
                    sw.WriteLine("escrito");
                    sw.WriteLine("pelo sistema");
                }
            }
            return caminhoArquivo_usado;
        }

        private static string EscreverMaiNoArquivoSimples_usado(string caminhoArquivo_usado)
        {
            caminhoArquivo_usado = caminhoArquivo_usado.TransformarCaminho();
            //SE O ARQUIVO EXISTE DE FATO ELE ABRE E ADICIONA TEXTO
            if (File.Exists(caminhoArquivo_usado))
            {                
                using (StreamWriter sw = File.AppendText(caminhoArquivo_usado))
                {
                    sw.WriteLine("mais e mais texto");
                    sw.WriteLine("sendo escrito");
                    sw.WriteLine("pelo sistema de novo");
                }
            }
            return caminhoArquivo_usado;
        }

        public static void Execute()
        {
            //SETANDO OS CAMINHOS TRATADOS
            var caminho = @"~/dxs_arquivo_api.txt".TransformarCaminho();
            var moverParaCaminho = @"~/dxs_arquivo_api_movido.txt".TransformarCaminho();
            var copiarParaCaminho = @"~/dxs_arquivo_api_movido_copiado.txt".TransformarCaminho();
            //ESCREVENDO UM NOVO ARQUIVOS E REESCREVENDO NELE
            EscreverMaiNoArquivoSimples_usado(EscreverArquivoSimples(caminho));
            //FAZENDO A LEITURA E MOVENDO OS ARQUIVOS
            Console.WriteLine(LerArquivoSimples(caminho));
            Console.WriteLine(LerDadosArquivoSimples(caminho));
            Console.WriteLine((MoverArquivoSimples(caminho, moverParaCaminho)) ? "SUCESSO MOVIDO!" : "FALHOU DE SER MOVIDO!");
            Console.WriteLine((CopiarArquivoSimples(moverParaCaminho, copiarParaCaminho)) ? "SUCESSO COPIADO!" : "FALHOU DE SER COPIADO!");
            //DELETANDO TODOS ARQUIVOS CRIADOS
            ApagarTodosArquivoSimples(caminho, moverParaCaminho, copiarParaCaminho);
        }
    }
}
