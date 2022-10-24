namespace TestApp;

internal class App
{
    private static void Main(string[] args)
    {
        // Affichage de la fonction toString de la class Modules/TestModule.cs
        Console.WriteLine($"toString de la classe 'TestModule' : {Modules.TestModule.toString()}");

        //Affichage de la fonction toString de la classe actuelle
        Console.WriteLine($"toString de la classe 'App' : {toString()}");

        String hello = "Chaine";
        String world = "assemblée";
        String greeting = hello + " " + world;
        Console.WriteLine(greeting);
    }

    public static string toString()
    {
        return "NOT Hello, World";
    }
}
