namespace TestApp;

internal class App
{
    private static void Main(string[] args)
    {
        Console.WriteLine($"toString de la classe 'TestModule' : {Modules.TestModule.toString()}");
        Console.WriteLine($"toString de la classe 'App' : {toString()}");
    }

    public static string toString(){
        return "NOT Hello, World";
    }
}
