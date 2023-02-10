using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("John", "3", "16");
        Console.WriteLine(reference.GetReference());

        string example = "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.";
        Scripture scripture = new Scripture();
        scripture.SetScripture(reference, example);

        string exit = "";
        while (exit != "exit")
        {
            Console.Clear();
            string response = scripture.getScripture();
            Console.WriteLine(response);
            exit = Console.ReadLine().ToLower();
            scripture.HideRandomWord();
        }


    }
}