// Hello World! program
namespace DesafioF360
{
    class Hello
    {
        static void Main(string[] args)
        {
            Funcoes f = new Funcoes();

            int preposicoes = f.acharPreposicao();
            int acharVerbos = f.acharVerbos();
            int verbos = f.verbos;
            int verbosPrimeiraPessoa = f.verbosPrimeiraPessoa;

            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("----------------DESAFIO F°360----------------");
            Console.WriteLine("1-) E no Texto B, quantas preposições existem?");
            Console.WriteLine("R:" + preposicoes);
            Console.WriteLine("2-) Ja no Texto B, quantos são os verbos");
            Console.WriteLine("R:" + verbos);
            Console.WriteLine("3-) E quantos verbos no texto B estão em primeira pessoa?");
            Console.WriteLine("R:" + verbosPrimeiraPessoa);
            Console.WriteLine("4: Como seria a lista de vocabulário do Texto B?");
            Console.WriteLine(f.TextoOrdenado());
            Console.WriteLine("5: E no Texto B? Quantos números bonitos existem?");
            Console.WriteLine(f.Numeros());
            Console.WriteLine("---------------------------------------------");



        }
    }
}