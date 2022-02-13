namespace DXS_CSHARP_fundamentals.MethodsAndClasses
{
    public class Members
    {
        public static void Execute(){
            //CRIAÇÃO E ATRIBUIÇÃO DE OBJETOS
            //METODO DE CRIAÇÃO E ATRIBUIÇÃO SIMPLES
            Pessoa_object novaPessoa1 = new Pessoa_object();
            novaPessoa1.Nome = "José Ferreira";
            novaPessoa1.Idade = 45;
            novaPessoa1.seApresentarNoConsole();
            //METODO DE CRIAÇÃO E ATRIBUIÇÃO USANDO CONSTRUTOR
            Pessoa_object novaPessoa2 = new Pessoa_object("Juarez", 34);
            novaPessoa2.seApresentarNoConsole();
            //METODO DE CRIAÇÃO E ATRIBUIÇÃO POR CHAVE
            Pessoa_object novaPessoa3 = new Pessoa_object() {
                Nome = "Robertão Josué",
                Idade = 56                
            };
            novaPessoa3.seApresentarNoConsole();
        }
    }
}