
using ConsoleAluguel.Entidades;
using System.Linq;

internal class Program
{
    private static async Task Main(string[] args)
    {
        Vetor vet = new Vetor();
        List<string> ListaAlugueis = await vet.AdicionaVetor()
                                               .Getlist();
        foreach (string Lista in ListaAlugueis)
        {
            Console.WriteLine(Lista);
        }
    }
}