using System;

namespace DXS_CSHARP_fundamentals.MethodsAndClasses
{
    interface Ponto {
        //METODO PUBLICO IMPLICITO DA INTERFACE
        void MoverNaDiagonal(int delta);
    }

    //STRUCT ACEITA IMPLEMENTAR INTERFACE
    struct Coordenada: Ponto {
        //ACEITA ATRIBUTOS
        public int X;        
        public int Y;
        //ACEITA COSNTRUTORES
        public Coordenada(int x, int y){
            X = x;
            Y = y;
        }
        //ACEITA METODOS
        public void MoverNaDiagonal(int delta){
            X += delta;
            Y += delta;
        }
    }

    //STRUCT VS CLASSES
    public struct StructPonto{
        public int X;
        public int Y;
    }
    public class ClassPonto{
        public int X;
        public int Y;
    }

    public class TroqueParaTipoStruct{
        public string Nome;
    }

    public class ClassVsStructs
    {
        public static void Execute(){
            //ACPLICAÇÃO BASICA DE UMA STRUCT
            Coordenada coordenadaInicial;
            coordenadaInicial.X = 2;
            coordenadaInicial.Y = 2;
            coordenadaInicial.MoverNaDiagonal(13);
            Console.WriteLine($"Coordenada Inicial: X = {coordenadaInicial.X} e Y = {coordenadaInicial.Y}");
            var coordenadaFinal = new Coordenada(y: 100, x: 100);
            coordenadaFinal.MoverNaDiagonal(13);
            Console.WriteLine($"Coordenada Inicial: X = {coordenadaFinal.X} e Y = {coordenadaFinal.Y}");
            
            //STRUCT VS CLASSES - INICIO
            //STRUCT - INICIO
            StructPonto sPonto = new StructPonto {
                X = 1,
                Y = 3
            };
            //ATRIBUIÇÃO POR VALOR | NÃO POR REFERENCIA
            StructPonto sPonto_copy = sPonto;
            sPonto.X += 2;
            Console.WriteLine($"StructPoint: X = {sPonto.X} e Y = {sPonto.Y}");
            Console.WriteLine($"StructPoint Copy: X = {sPonto_copy.X} e Y = {sPonto_copy.Y}");
            //STRUCT - FIM
            
            //CLASSE - INICIO
            ClassPonto cPonto = new ClassPonto {
                X = 1,
                Y = 3
            };
            //ATRIBUIÇÃO POR REFERENCIA | NÃO POR VALOR
            ClassPonto ClassPonto_copy = cPonto;
            cPonto.X += 2;
            Console.WriteLine($"ClassPoint: X = {cPonto.X} e Y = {cPonto.Y}");
            Console.WriteLine($"ClassPoint Copy: X = {ClassPonto_copy.X} e Y = {ClassPonto_copy.Y}");
            //CLASSE - FIM

            TroqueParaTipoStruct _experimento = new TroqueParaTipoStruct();
            _experimento.Nome = "Nome padrão";  
            //SE TROCAR CLASS PARA STRUCT ESSA ATRIBUIÇÃO SEGUE POR VALOR E NAO POR REFERENCIA | CODIGO É INALTERADO, SOMENTE OBTERÁ RESULTADOS DIFERENTES
            TroqueParaTipoStruct _experimento_copy = _experimento;
            _experimento.Nome = "Outro nome";            
            Console.WriteLine($"Nome da var original: '{_experimento.Nome}' | Nome da var cópia: '{_experimento_copy.Nome}'");            
            //STRUCT VS CLASSES - FIM
        }
    }
}