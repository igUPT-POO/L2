namespace L2;

public class Exemplu : IExemplu
{
    private Dictionary<char, string> _exempluDictionary = 
        new Dictionary<char, string>()
    {
        { '1', "exemplu 1" },
        { '2', "exemplu 2" } 
    };
    
    public void AfisareExemplu()
    {
        Console.WriteLine("Id | Descriere");
        foreach (var item in _exempluDictionary)
        {
            Console.WriteLine($" {item.Key} | {item.Value}");
        }
    }

    public void Adaugare()
    {
        Console.WriteLine("Introdu ID pentru exemplu");
        var id = Console.ReadKey().KeyChar;
        
        Console.WriteLine();
        Console.WriteLine("Introdu DESCRIERE pentru exemplu");
        var descriere = Console.ReadLine() ?? "N/A";
        
        AdaugareIntern(id, descriere);
    }
    
    private void AdaugareIntern(char id, string descrire)
        => _exempluDictionary.Add(id, descrire);
}