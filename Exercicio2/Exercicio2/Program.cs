using System;
class Program
{
    static void Main(string[] args)
    {
        int tamanhoListaConvidados = 5;
        string[] listaConvidados = new string[tamanhoListaConvidados];
        for (int i = 0; i < tamanhoListaConvidados; i++)
        {
            Console.WriteLine($"Digite o nome do {i + 1}º convidado:");
            listaConvidados[i] = Console.ReadLine();
        }
        Console.WriteLine("Lista de convidados:");
        foreach (string convidado in listaConvidados)
        {
            Console.WriteLine(convidado);
        }
        Console.ReadLine();
    }
}
