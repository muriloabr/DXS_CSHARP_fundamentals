using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXS_CSHARP_fundamentals.ObjectOrientation
{
    internal class Interface
    {
        //INTERFACES PODEM TER SOMENTE METODOS PUBLICOS
        interface TesteValidez {
            bool numeroMaiorQueZero(int valor);
        }
        interface TesteInteiro
        {
            bool numeroVerificarInteiro(string valor);
        }

        //CLASSES PODEM HERDAR SÓ UMA OUTRA CLASSE E PODE IMPLEMENTAR MUITAS INTERFACES
        //UMA CLASSE ABSTRATA QUE IMPLEMENTAR UMA INTERFACE TERA QUE IMPLEMENTAR OS METODOS
        abstract class BaseMaquinaCalcular: TesteValidez
        {
            string mensagemPadraoDeFimDeCaculo()
            {
                return "Calculo feito com sucesso!";
            }
            //METODO HERDADO E IMPLEMENTADO COM VIRTUAL POSSIBILITANDO SER SOBRESCRITO A QUEM HERDAR ESSA CLASSE ABSTRATA
            public virtual bool numeroVerificarInteiro(string valor)
            {
                bool daCerto = int.TryParse(valor.ToString(), out int resposta);
                return daCerto;
            }
            //METODO DA INTERFACE IMPLEMENTADO
            public bool numeroMaiorQueZero(int valor)
            {   
                return false; //COMO NAO É VIRUTAL ELE NAO PODE SER SOBRESCRITO ENTAO SERÁ SEMPRE FALSE AO CHAMAR A INSTANCIA HERDADA PELA TIPO BaseMaquinaCalcular
            }
        }

        //INTERFACE PODE IMPLEMENTAR VARIAS OUTRAS INTERFACES MAS NAO PODE HERDAR CLASSES
        //TODOS METODOS HERDADOS DE INTERFACES POR ESTA INTERFACE VÃO SER REPASSADOS PARA A CLASSE QUE HERDAR E IMPLEMENTAR
        interface OperacaoBinaria : TesteValidez, TesteInteiro
        {
            //NENHUM METODO DE INTERFACE PODE SER IMPLEMENTADO ENTAO SAO TODOS PUBLIC E ABSTRACTS IMPLICITAMENTE
            int Operacao(int a, int b);
        }
        //CLASSE HERDADA FEZ UMA IMPLEMENTACAO DA INTERFACE E AQUI ESTA IMPLMENTANDO NOVAMENTE A INTERFACE ERRONEAMENTE
        class Soma: BaseMaquinaCalcular, OperacaoBinaria
        {
            //OBRIGATORIAMENTE SERA PUBLIC AO IMPLEMENTAR
            public int Operacao(int a, int b)
            {
                return a + b;
            }
            public bool numeroMaiorQueZero(int valor) //METODO EM MODO OCULTAÇÃO QUANDO CHAMADO PELA INSTANCIA SOMA()
            {
                if (valor > 0)
                {
                    return true;
                } else
                {
                    return false;
                }
                
            }
            public bool numeroVerificarInteiro(string valor)
            {
                bool daCerto = int.TryParse(valor.ToString(), out int resposta);
                return !daCerto;
            }
        }
        
        class Subtracao : BaseMaquinaCalcular, OperacaoBinaria
        {
            //OBRIGATORIAMENTE SERA PUBLIC AO IMPLEMENTAR
            public int Operacao(int a, int b)
            {
                return a - b;
            }
            public bool numeroMaiorQueZero(int valor)//METODO EM MODO OCULTAÇÃO QUANDO CHAMADO PELA INSTANCIA SUBTRACAO()
            {
                if (valor > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            public override bool numeroVerificarInteiro(string valor)
            {
                bool daCerto = int.TryParse(valor.ToString(), out int resposta);
                return daCerto;
            }
        }

        class Multiplicacao : BaseMaquinaCalcular, OperacaoBinaria
        {
            //OBRIGATORIAMENTE SERA PUBLIC AO IMPLEMENTAR
            public int Operacao(int a, int b)
            {
                return a * b;
            }
            public bool numeroMaiorQueZero(int valor)//METODO EM MODO OCULTAÇÃO QUANDO CHAMADO PELA INSTANCIA MULTIPLICACAO()
            {
                if (valor > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            public override bool numeroVerificarInteiro(string valor)
            {
                bool daCerto = int.TryParse(valor.ToString(), out int resposta);
                return daCerto;
            }
        }

        class Calculadora
        {
            private Soma somar;
            private Subtracao subtrair;
            private Multiplicacao multiplicar;
            public Calculadora(){
                somar = new Soma();
                subtrair = new Subtracao();
                multiplicar = new Multiplicacao();
            }
            public string ExecutarOperacoes(int a, int b)
            {
                //A IMPLEMENTACAO QUE OCULTAVA O METODO DESSA HERENAÇA É IGNORADO, PREVALECENDO O METODO ORIGINAL DE BaseMaquinaCalcular
                List<BaseMaquinaCalcular> BaseMaquinaCalcularList = new List<BaseMaquinaCalcular>
                {
                    somar,
                    subtrair,
                    multiplicar,
                };
                //A IMPLEMENTACAO, MESMO NAO SENDO EXPLICITA NO CODIGO, QUE SOBRESCREVE OBRIGATORIAMENTE O METODOS DESTA INTERFACE SERAO UTILIZADAS 
                List<OperacaoBinaria> OperacaoList = new List<OperacaoBinaria>
                {
                    somar,
                    subtrair,
                    multiplicar,
                };
                //IMPLEMENTADO PELA CLASSE CONCRETA ATRAVES DA IMPLEMENTAÇÃO PELA HERANÇA COM BaseMaquinaCalcular
                //E PELA OBRIGATORIEDADE DE OVERRIDE PELA INTERFACE OperacaoBinaria, AMBAS FAZEM COMPOSICAO COM TesteValidez
                //SENDO QUE PREVALECE A IMPLEMENTAÇÃO NA CLASSE  QUE OBRIGATORIAMENTE SOBRESCREVE A INTERFACE PURA AO IMPLEMENTAR OperacaoBinaria
                //OU SEJA, O MODO METODO OCULTADO PERDE PARA METODO SOBRESCRITO
                List<TesteValidez> TesteValidezList = new List<TesteValidez> 
                {
                    somar,
                    subtrair,
                    multiplicar,
                };
                string resultado = "";
                int contadorBaseCalcular = 0;
                foreach (var operacao in OperacaoList)
                {
                    resultado += $"RESULTADO POR OPERACAOBINARIAINTERFACE: {operacao.GetType().Name} = {operacao.Operacao(a,b)} resultado maior que zero? : {operacao.numeroMaiorQueZero(operacao.Operacao(a, b))} \n  RESULTADO POR BASEMAQUINADECALCULARCLASSABSTRACT : resultado maior que zero? : {BaseMaquinaCalcularList[contadorBaseCalcular].numeroMaiorQueZero(operacao.Operacao(a, b))} \n   RESULTADO POR TESTEVALIDEZINTERFACE : resultado maior que zero? : {TesteValidezList[contadorBaseCalcular].numeroMaiorQueZero(operacao.Operacao(a, b))} \n";
                    contadorBaseCalcular++;
                }
                return resultado;   
            }
        }

        public static void Execute()
        {
            Calculadora calc = new Calculadora();
            Console.WriteLine((calc.ExecutarOperacoes(100, 3)));
        }
    }
}
