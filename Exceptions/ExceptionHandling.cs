using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXS_CSHARP_fundamentals.Exceptions
{
    internal class ExceptionHandling
    {
        class Cliente
        {
            public double Saldo { 
                get { return Saldo; }
                set {
                    if (value > 100) //LANCANDO UMA EXCEÇÃO DO TIPO ArgumentException
                        throw new ArgumentException("NAO PODE O SALDO RECEBER VALOR MAIOR QUE 100!");
                    else if(value == 50)
                        throw new ErroCustomizado("SALDO RECEBENDO 50 DA ERRO TAMBÉM!"); 
                    else if(value < 11)
                        Saldo = int.Parse("praDarErroMesmo");
                    else
                        Saldo = value;
                }
            }   
        }
        //UMA CLASSE PODE HERDAR DE EXCESSAO PARA TRATAR UM TIPO ESPECIFICO DE ERRO CUSTOMIZADO
        public class ErroCustomizado: Exception
        {
            public ErroCustomizado() { }
            public ErroCustomizado(string mensagem) { }
            public ErroCustomizado(string mensagem, Exception excessaouInterna) : base(mensagem, excessaouInterna) { }
        }

        public static void Execute()
        {
            Cliente cliente = new Cliente();
            
            //TENTA EXECUTAR O BLOCO
            try {
                Console.Write("ADICIONAR SALDO AO CLIENTE: R$");
                cliente.Saldo = double.Parse(Console.ReadLine());
            } catch (ArgumentException ae) //CASO ERRO FOR DO TIPO ARGUMENTO
            {
                Console.WriteLine("ARGUMENTO INVALIDO: " + ae.Message + " | EXCEPTION TIPE: " + ae.GetType().Name);
            } catch (Exception e) //ERRO GENERICO
            {
                Console.WriteLine("ERRO DESCONHECIDO: " + e.Message + " | EXCEPTION TIPE: " + e.GetType().Name);
            }
            //SEMPRE EXECUTA NO ERRO OU NO SUCESSO!
            finally
            {
                Console.WriteLine("-*- OBRIGADO POR USAR NOSSOS SERVIÇOS! -*-");
            }
        }
    }
}
