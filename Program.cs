
using ConsoleAluguel.Entidades;

internal class Program
{
    private static async Task Main(string[] args)
    {
        Vetor vet = new Vetor();
        List<string> ListaAlugueis = await vet.AdicionaVetor()
                                               .Getlist();
        ListaAlugueis.Sort();
        foreach (string Lista in ListaAlugueis)
        {
            Console.WriteLine(Lista);
        }
    }
}