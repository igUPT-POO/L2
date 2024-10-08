namespace L2;

using System;

public class Aplicatie : IAplicatie
{
    private readonly string _meniuAplicatie = @"
In aceasta aplicatie avem urmatoarele posibilitati:
1 - Adaugare student
2 - Notare student
3 - Afisare medie disciplina
4 - Afisare catalog
5 - Exemplu Afisare
6 - Exemplu Adaugare
0 - Iesire
";
    
    private Exemplu _exemplu = new Exemplu();
    public void Start()
    {
        Console.WriteLine("Bun venit in aplicatie");
        var comanda = string.Empty;
        while (comanda != "0")
        {
            Console.WriteLine(_meniuAplicatie);
            Console.WriteLine("Ce comanda doriti sa executati?");

            comanda = Console.ReadLine();
            ExecutareComanda(comanda);
            
            Console.WriteLine("Apasa orice tasta pentru a continua");
            Console.ReadKey();
        }
    }

    private void ExecutareComanda(string comanda)
    {
        switch (comanda)
        {
            case "1":
                break;
            case "2":
                break;
            case "3":
                break;
            case "4":
                break;
                
            case "5":
                Console.ForegroundColor = ConsoleColor.Red;
                _exemplu.AfisareExemplu();
                Console.ForegroundColor = ConsoleColor.Black;
                break;
            case "6":
                _exemplu.Adaugare();
                break;
                
            case "0":
                Exit();
                break;
            default:
                comanda = string.Empty;
                break;
        }
    }
    private void Exit()
    {
        Console.WriteLine("Aplicatia se va inchide in 2 sec");
        Thread.Sleep(1000);
        Console.WriteLine("1...");
        Thread.Sleep(1000);
        Console.WriteLine("2...");
    }
}