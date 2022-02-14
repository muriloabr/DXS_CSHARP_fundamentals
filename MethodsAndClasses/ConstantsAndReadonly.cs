using System;

namespace DXS_CSHARP_fundamentals.MethodsAndClasses
{
    public class ConstantsAndReadonly
    {
        public class Cliente{            
            //VARIAVEL QUE PODE SER SETADA NO CONSTRUTOR OU NA INICIALIZAÇÃO SOMENTE
            readonly string Nome;
            public readonly DateTime Nascimento;
            //CONSTANTE QUE É SETADA NA INICIALIZAÇÃO SOMENTE
            const int constante = 1000;

            public Cliente(){}
            public Cliente(string nome, DateTime nascimento) {
                //READRONLY VAI SER MODIFICADO DURANTE A EXECUÇÃO DENTRO DO CONSTRUTOR ASSUMINDO SUA FORMA PERPÉTUA NO FINAL DO PROCESSAMENTO
                Nome = nome;                
                Nascimento = nascimento;
                Nascimento = new DateTime(2022, 2, 13);
                Nome = "NOME PADRÃO";
            }
            public void exibirCliente(){
                Console.WriteLine($"Sou {Nome}, nasci em {Nascimento.Day.ToString("D2")}/{Nascimento.Month.ToString("D2")}/{Nascimento.Year}");
            }
        }
        public static void Execute(){
            //READONLY POSSIBILITA SER SETADA UMA VEZ SOMENTE, EM UM PROCESSAMENTO DENTRO DO COSNTRUTOR
            Cliente cliente = new Cliente("Juarez", new DateTime(1980, 5, 28));
            cliente.exibirCliente();
        }
    }
}