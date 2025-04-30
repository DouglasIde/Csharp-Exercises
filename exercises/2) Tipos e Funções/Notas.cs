using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite uma nota para sua experiência com C#");
        int notaMedia = Console.ReadLine();
        if (notaMedia => 5)
        {
            Console.WriteLine("O C# foi aprovado!! :)")
        } else
        {
            Console.WriteLine("Que pena que sua experiência não foi tão boa!! :(");
        }
    }
}
