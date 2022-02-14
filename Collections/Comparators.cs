using System;

namespace DXS_CSHARP_fundamentals.Collections
{

    public class ProdutoDaLoja {
        public string Nome;
        public double Preco;

        public ProdutoDaLoja(string nome, double preco) {
            Nome = nome;
            Preco = preco;
        }
        //VISUAL STUDIO IMPLEMENTA ESSES OVERRIDES ABAIXO USANDO AS PROPRIEDADES! MELHORA O USO NA REGRA DE NEGOCIO!

        //SOBRESCREVENDO O METODO EQUALS() QUE FAZ COMPARACOES ENTRE OBJETOS DO MESMO TIPO
        //RECEBE POR PADRAO A FILTRAGEM DOS RESULTADOS ENTREGUES PELO GETHASCODE EM ESTRUTURAS COMO HASHSETS
        public override bool Equals(object obj)
        {
            ProdutoDaLoja produtoAComparar = (ProdutoDaLoja)obj;
            bool mesmoNome = Nome == produtoAComparar.Nome;
            bool mesmoPreco = Preco == produtoAComparar.Preco;
            return mesmoNome && mesmoPreco;
        }
        //SOBRESCREVENDO GETHASCODE | USADO EM PRE FILTRAGEM QUE REPASSA PARA O EQUALS TESTAR COMO EM HASHSETS
        // POR PADRAO USA O ENDERECO DE MEMORIA, PASSANDO NO TESTE SOMENTE AS VARIAVEIS DE MESMA REFERENCIA        
        public override int GetHashCode()
        {
            return Nome.Length;
        }
    }

    public class Comparators
    {
        public static void Execute(){
            //CRIANDO DOIS OBJETOS DIFERENTES E SEMELHANTES EM VALORES
            var produto1 = new ProdutoDaLoja("Canetao", 2.78);
            var produto2 = new ProdutoDaLoja("Canetao", 2.78);
            //COMPARAÇÃO SIMPLES DIRETA DE ENDEREÇO DE MEMORIA
            Console.WriteLine($"São iguais? : {produto1 == produto2}");
            //COMPARAÇÃO DIRETA DE ENDEREÇO DE MEMORIA
            Console.WriteLine($"São iguais? : {produto1.Equals(produto2)}");            
        }
    }
}