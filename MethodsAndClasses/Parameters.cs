using System;

namespace DXS_CSHARP_fundamentals.MethodsAndClasses
{
    public class Parameters
    {
        //USO DE PARAMS RECEPCIONANDO INCONTÁVEIS VALORES STRINGS
        public static void Recepcionar(params string[] pessoas){
           foreach(var pessoa in pessoas){
               Console.WriteLine($"Olá {pessoa}");               
           } 
        }

        //PARAMETROS NOMEADOS
        public static void exibirFormatado(int dia, int mes, int ano){
            Console.WriteLine("{0:D2}/{1:D2}/{2}", dia, mes, ano);            
        }
        //PARAMETROS POR REFERENCIA DE INSTANCIA
        public static void AlterarAReferencia(ref int numero){
            numero += 999; //ALTERA O VALOR ORIGINAL DIRETO NA REFERENCIA RECEBIDA
        }

        //PARAMETROS DE SAIDA SOMENTE | O METODO PODE TER RETORNO E AINDA SOLTAR VÁRIAS VARIAVEIS DE out ALEM DE TER VARIAVEIS DE ETNRADA COMO PARAMETRO
        //PARAMETROS OPCIONAIS SÃO ALOCADOS NO FIM DA ORDEM DE ESCRITA POR CONVENÇÃO
        public static bool CriarSaida(out int numeroSaida, out int outroNumeroSaida, int numeroMultiplicadorEntrada = 100){
            numeroSaida = 0; //INICIALIZADO OBRIGATORIA MAS JA CONSTRUIDO NO PARAMETRO DO METODO
            int numeroCalculado = 100;
            numeroSaida += 999 + numeroCalculado; //MANIPULO
            numeroCalculado *= 2 * numeroMultiplicadorEntrada;
            numeroMultiplicadorEntrada = 1000000; //COMO PARAMETRO POR VALOR NÃO AFETARÁ A VARIAVEL ORIGINAL
            outroNumeroSaida = numeroCalculado + numeroSaida; //INICIALIZADO MAS JA CONSTRUIDO NO PARAMETRO DO METODO
            //numeroCalculado = 400 | numero = 1099 | outroNumero = 1499 | MAS A SAÍDA É SÓ O numero E outroNumero
            return true;
        }

       public static void Execute(){
            //ENVIANDO INCONTÁVEIS VALORES STRINGS POR PARAMETRO
            Recepcionar("Juarez", "Marco Antonio", "Soberando Palhares", "González Dias", "Pedro Alcantara");
            //ENVIANDO PARAMETROS NOMEADOS
            exibirFormatado(ano:1995, dia:3,mes:2);
            //AO PASSAR PARA UM PARAMETRO out USAR ESTA VARIAVEL ELA PERDE SEU VALOR POIS É OBRIGADO A INICIALIZAR DENTRO DO METODO,
            //ENTAO A SAIDA APROVEITA O MESMO ESPACO DE MEMORIA DESSA VARIAVEL ALTERANDO SEU VALOR
            int numeroSaida1 = 100000;
            int numeroMultiplicador = 2;
            bool deuCerto = false;
            //PARAMETROS DE SAIDA + PARAMETRO NOMEADO: ASSUME POR POSICAO OU DIRECIONA POR NOMEACAO + FUNCAO COM RETURN
            // + PARAMETRO OPCIONAL COM VALOR PADRAO CASO NAO RECEBER NADA POR ELE | PARAMETRO out NAO PODE TER VALOR PADRAO
            deuCerto = CriarSaida(out numeroSaida1, numeroMultiplicadorEntrada: numeroMultiplicador, outroNumeroSaida: out int numeroSaida2);
            if(deuCerto){
                Console.WriteLine($"SAIDA CRIADA COM SUCESSO!");
            };
            Console.WriteLine($"Variavel numero gerada do metodo saida = {numeroSaida1} | outra = {numeroSaida2} | numeroMultiplicador = {numeroMultiplicador}");
            //ENVIANDO PARAMETROS POR REFERENCIA
            int _valor = 1; //INICIALIZO
            AlterarAReferencia(ref _valor); 
            Console.WriteLine($"Meu valor alterado sem atribuição, por um método sem retorno = {_valor}");            
       }
    }
}