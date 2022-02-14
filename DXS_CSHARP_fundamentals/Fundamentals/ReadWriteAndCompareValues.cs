using System;
using System.Globalization;

namespace DXS_CSHARP_fundamentals
{
    public class ReadWriteAndCompareValues
    {
        public static void Execute(){

            Console.WriteLine("================= FORMATAÇÃO DE VALORES =====================");

            Console.WriteLine("Digite seu salário: ");
            //CONVERTE PARA DOUBLE SEM CORRIGIR O USO DE PONTO E VÍRGULA CAPTURADO!
            double salario = 1256.45; //double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //EXIBE COM INTERPOLACAO E FORMAT APLICADO - INICIO
            //ARREDONDA PARA 2 CASAS DECIMAIS
            Console.WriteLine("Digitado : {0}", salario.ToString("F2"));
            //FOMATA PARA MOEDA DA CULTURA ESCOLHIDA
            Console.WriteLine($"Digitado : {salario.ToString("C", CultureInfo.CreateSpecificCulture("en-us"))}");
            //PERCENTUAL = *100 ADICAO DE %
            Console.WriteLine("Digitado : {0}", salario.ToString("P"));
            //ARREDONDA PARA .### CASAS DECIMAIS
            Console.WriteLine("Digitado : {0}", salario.ToString("#.###"));            
            //COMPLETA AS CASAS DECIMAIS COM ZERO MANTENDO 10 POSIÇÕES PRENCHIDAS [SOMENTE PARA VARIAVEIS: INT]
            int salario_int = int.Parse(salario.ToString().Replace(".","").Replace(",",""));
            Console.WriteLine("Digitado : {0}", salario_int.ToString("D10"));
            //EXIBE COM INTERPOLACAO E FORMAT APLICADO - FIM
            
            Console.WriteLine("================= CONVERSÃO DE VALORES =====================");

            //CONERSÃO DE VALORES - INICIO
            double _valorDouble = 1665.797;
            int _valorInteger = 1564;

            _valorDouble = _valorInteger; // VALOR RECEBIDO EM VARIAVEL MAIOR É: CONVERSÃO EXPLÍCITA POIS NÃO TEM PERDA DE DADOS
            Console.WriteLine("Converção implícita double = int : {0}", _valorDouble.ToString());

            _valorDouble = 9089.956;

            _valorInteger = (int) _valorDouble; // ARREDONDA RETIRANDO AS CASAS DECIMAIS
            Console.WriteLine("Converção explícita (int): {0}", _valorInteger.ToString());

            _valorInteger = int.Parse(((long) _valorDouble).ToString()); // SÓ CONVERTE STRINGS DE VALORES QUE FOREM REALMENTE INTEGERS = SEM CASAS DECIMAIS
            Console.WriteLine("Converção explícita int.Parse(): {0}", _valorInteger.ToString());

            _valorInteger = Convert.ToInt32(_valorDouble); // ARREDONDA QUALQUER NUMERO PARA CIMA USANDO AS CASAS DECIMAIS
            Console.WriteLine("Converção explícita Convert.ToInt32(): {0}", _valorInteger.ToString());
            
            int.TryParse(_valorDouble.ToString(), out _valorInteger); // SÓ CONVERTE STRINGS DE VALORES QUE FOREM REALMENTE INTEGERS = SEM CASAS DECIMAIS | SENÃO SETA VALOR ZERO
            Console.WriteLine("Converção explícita int.TryParse(out): {0}", _valorInteger.ToString());
            //CONERSÃO DE VALORES - FIM

            Console.WriteLine("================= OPERADORES ARITMÉTICOS ==================");

            var _preco = 1500.59;
            var _imposto = 355;
            var _desconto = 0.16;
            //OPERAÇÃO SIMPLES + - * /
            double _total = _preco + _imposto;
            var _totalComDesconto = _total - _total * _desconto;
            Console.WriteLine($"[CÁLCULO SIMPLES] Preço final = {_totalComDesconto}");
            //MATH.POW PARA POTENCIAÇÃO
            Console.WriteLine($"[CÁLCULO COM POTÊNCIA USANDO MATH.POW] IMC = {71}KG / {1.85} X {1.85} = {(71/(Math.Pow(1.85, 2))).ToString("F2")}");
            //% É O MÓDULO, OU SEJA, O RESTO DE UMA DIVISÃO
            Console.WriteLine($"[CÁLCULO COM MÓDULO] valor par : {(int)(_preco) % 2}");
            Console.WriteLine($"[CÁLCULO COM MÓDULO] valor impar : {_imposto % 2}");
            
            Console.WriteLine("================= OPERADORES ATRIBUIÇÃO ==================");

            //ATRIBUINDO O VALOR =
            var _numero1 = 3;
            // SUBSTITUINDO O VALOR =
            _numero1 = 9;
            //ACRESCENTANDO AO VALOR +=
            _numero1 += 3;
            //SUBTRAINDO DE VALOR -=
            _numero1 -= 6;
            //MULTIPLICANDO VALOR POR *=
            _numero1 *= 2;
            //DIVIDINDO O VALOR -=
            _numero1 /= 2;
            Console.WriteLine($"Numero = { _numero1 }");

            Console.WriteLine("================= OPERADORES RELACIONAIS ==================");

            double _nota = 5.4;
            double _notaDeCorte = 8.3;
            Console.WriteLine($"A nota foi ruim? { !(_nota > _notaDeCorte) }");
            Console.WriteLine($"A nota foi a mesma que a nota de corte? { (_nota == _notaDeCorte) }");
            Console.WriteLine($"A nota foi diferente da nota de corte? { (_nota != _notaDeCorte) }");
            Console.WriteLine($"A nota foi maior que a nota de corte? { (_nota >= _notaDeCorte) }");

            Console.WriteLine("================= OPERADORES LÓGICOS ==================");

            var _executouTrabalho1 = false;
            var _executouTrabalho2 = true;
            // OPERADOR LOGICO AND
            bool _sabadoLivre = _executouTrabalho1 && _executouTrabalho2;
            Console.WriteLine($"SABADO SERÁ LIVRE SE TERMINOU OS DOIS TRABALHOS : {_sabadoLivre}");
            // OPERADOR LOGICO OR
            bool _domingoLivre = _executouTrabalho1 || _executouTrabalho2;
            Console.WriteLine($"SE QUALQUER TRABALHO FOR EXECUTADO DOMINGO SERA LIVRE : {_domingoLivre}");
            // OPERADOR LOGICO XOR
            bool _proximoFdsLivre = _executouTrabalho1 ^ _executouTrabalho2;
            Console.WriteLine($"SE APENAS UM TRABALHO FOI EXECUTADO O PRÓXIMO FDS SERA LIVRE : {_proximoFdsLivre}");
             
            Console.WriteLine("================= OPERADORES UNÁRIOS ==================");

            var _valorNegativo = -509;
            var _valorPositivo = 969;
            var _valorBooleano = true;

            //NEGAÇÃO ARITMÉTICA
            Console.WriteLine($"Negação aritmética - {_valorPositivo} : {-_valorPositivo}");
            Console.WriteLine($"Negação aritmética + {_valorNegativo} : {+_valorNegativo}");
            //NEGAÇÃO LÓGICA
            Console.WriteLine($"Negação lógica !{_valorBooleano} : {!_valorBooleano}");

            //OPERADORES UNÁRIOS DE ATRIBUIÇÃO: EM ATRIBUIÇÃO TRANSFORMAM O VALOR CONFORME -- ++
            _valorPositivo--;
            ++_valorPositivo;
            //EM ATRIBUIÇÃO PREFIXADA: EXECUTA ANTES DA COMPARAÇÃO | EM ATRIBUIÇÃO POSFIXADA: EXECUTA DEPOIS DA COMPARAÇÃO
            Console.WriteLine($"valor = {_valorPositivo} : {(_valorPositivo-- == --_valorPositivo)}");

            Console.WriteLine("================= OPERADOR TERNÁRIO ==================");
            
            //TERNARIO COMPOSTO DE: EXPRESSAO ? OPERANDO CASO TRUE : OPERANDO CASO FALSE
            Console.WriteLine($"Sua nota foi: {_nota} e a nota de corte foi: {_notaDeCorte}," +
            $" se sua nota foi suficiente ou executou os dois trabalhos você passou?" +
            $" { (((_nota > _notaDeCorte) || (_executouTrabalho1 && _executouTrabalho2))?"SIM!":"NÃO!") }");           
        }
    }
} 