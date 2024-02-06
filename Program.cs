
using ConsoleAluguel.Entidades;
using System.Linq;

internal class Program
{
    private static async Task Main(string[] args)
    {
        Vetor vet = new Vetor();
        List<string> ListaAlugueis = await vet.AdicionaVetor()
                                               .Getlist();

        var OrderByAsc = ListaAlugueis.OrderBy(e => e).ToList<string>();
        foreach (string Lista in OrderByAsc)
        {
            Console.WriteLine(Lista);
        }
    }
}