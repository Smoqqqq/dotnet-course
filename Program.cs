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

        String nom = "Doe";
        String prenom = "John";
        string john = String.Format("Nom: {0} \nPrénom: {1}", nom, prenom);
        Console.WriteLine(john);

        Int16 age = 17;
        Boolean majeur = (age > 18) ? true : false;
        Console.WriteLine($"majeur: {majeur}");

        Int16 ageJhon = 28;
        Boolean majeurJhon = (ageJhon > 18) ? true : false;
        Console.WriteLine($"majeur: {majeurJhon}");
    }

    public static string toString()
    {
        return "NOT Hello, World";
    }
}
