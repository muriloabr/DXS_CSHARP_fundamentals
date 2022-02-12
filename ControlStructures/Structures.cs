using System;

namespace DXS_CSHARP_fundamentals.ControlStructures
{
    public class Structures
    {
        public static void Execute(){

            Console.WriteLine("================= ESTRUTURAS IF ELSE SWITCH ==================");

            //ESTRUTURA IF/ELSE           
            Console.Write("Qual a cor do semáforo? [R|Y|G] : ");
            char.TryParse(Console.ReadLine(), out char _respostaSemaforo);
            
            var _semaforo =  (_respostaSemaforo).ToString().ToUpper().Equals("R");
            //IF COM VARIAVEL BOOLEANA
            if(_semaforo){
                Console.WriteLine("SEMÁFORO FECHADO : RED");
            }
            //IF COM EXPRESSAO
            if((_respostaSemaforo).ToString().ToUpper().Equals("Y")){
                Console.WriteLine("SEMÁFORO FECHANDO... : YELLOW");
            }
            //ELSE IF COM EXPRESSAO
            else if((_respostaSemaforo).ToString().ToUpper().Equals("G")){
                Console.WriteLine("SEMÁFORO ABERTO : GREEN");
            }
            else {
                 Console.WriteLine("SEMÁFORO QUEBRADO!");
            } 

            //ESTRUTURA SWITCH          
            switch((_respostaSemaforo).ToString().ToUpper()){
                case "R":
                case "Y":
                case "G":
                    Console.WriteLine("SEMAFORO FUNCIONANDO BEM!");
                break;
                default:
                    Console.WriteLine("DEFEITO ENCONTRADO!");
                break;
            }

            Console.WriteLine("================= ESTRUTURA DO WHILE ==================");

            //ESTRUTURA WHILE            
            Random _aleatoriedade = new Random();
            int _inicial = 1;
            int _final = 100;
            //RANDOM DE 1 A 100
            int _numeroAleatorio = _aleatoriedade.Next(_inicial, _final+1);
            bool _numeroFoiEncontrado = false;
            int _tentativasPalpite = 2;
            Console.WriteLine("Enquanto espera o semáforo, vamos jogar ----------");
            while(_tentativasPalpite > 0 && !_numeroFoiEncontrado){
                Console.Write($"[{_tentativasPalpite} PALPITE{((_tentativasPalpite>1)?"S":"")} RESTANTE{((_tentativasPalpite>1)?"S":"")}] Qual número entre {_inicial} a {_final} estou pensando? : ");
                int.TryParse(Console.ReadLine(), out int _resposta);                
                if(_resposta == _numeroAleatorio){
                    _numeroFoiEncontrado = true;
                    var _corOriginalFundoPrompt = Console.BackgroundColor;
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine($"Acertou! Com {--_tentativasPalpite} tentativa{((_tentativasPalpite>1)?"s":"")} restante{((_tentativasPalpite>1)?"s":"")}.");
                    Console.BackgroundColor = _corOriginalFundoPrompt;
                } else if (_resposta > _numeroAleatorio){
                    Console.WriteLine("Errou! É um valor menor!");
                } else if (_resposta < _numeroAleatorio){
                    Console.WriteLine("Errou! É um valor maior!");
                }
                _tentativasPalpite--;
            }
            if(_numeroFoiEncontrado)
            {
                Console.WriteLine($"Você é bom mesmo! Valeu");                
            } else
            {
                Console.WriteLine($"Ganhei dessa vez! O número era {_numeroAleatorio}");
            }
            string _palavra; 
            //ESTRUTURA DO WHILE EXECUTA PELO MENOS UMA VEZ DEPOIS DECIDE SE REPETE
            do{
                Console.Write("Quer repetir? [S/N] : ");
                _palavra = Console.ReadLine();                
            } while(_palavra[0].ToString().ToUpper().Equals("S"));

            Console.WriteLine("================= ESTRUTURAS FOR FOREACH ==================");
            
            Console.WriteLine($"COM CONTADOR: ");            
            //COM INICALIZAÇÃO DE VARIAVEL E INCREMENTO
            for(int i=0; i < 10; i++){
                Console.WriteLine($"Nº : {i+1}");
            }

            Console.WriteLine($"FOR INFINITO SOMENTE COM EXPRESSAO INDEPENDENTE DE CONTADOR: ");
            int _contadorInterno = 0;
            //SEM INICALIZAÇÃO DE VARIAVEL NEM INCREMENTO
            for(; _contadorInterno < 10;){
                //_contadorInterno++ FAZ O CALCULO, RETORNA E DEPOIS ACRESCENTA +1 AO VALOR
                Console.WriteLine($"Nº : {_contadorInterno++ + 1}");                
            }
            Console.WriteLine($"COM FOREACH: "); 
            foreach(var _letra in _palavra){
                Console.WriteLine($"Estamos lendo a letra: '{_letra}'");                
            }

            Console.WriteLine("================= SAINDO DE ESTRUTURAS USANDO BREAK ==================");
            
            //USANDO BREAK PARA IDENTIFICAR O ITEM PROCURADO E SAIR DO LAÇO DE REPETIÇÃO
            for(int i = _final; i != _inicial; i--){
                if(i == _numeroAleatorio){
                    Console.WriteLine($"#{i} Encontramos!");
                    break;
                } else {
                    Console.WriteLine($"#{i} : Não é o numero soretado!");                    
                }
            }
        }
    }
}