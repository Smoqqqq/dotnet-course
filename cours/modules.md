# Modules C#

un module est importé avec using:  
```c#
using System;
```
avec `Namespace.Class.function` 
```c#
//  Namespace   .Class          .function
    Modules     .TestModule     .toString()
```

On peut également créer nos propres modules et les utiliser:  
```c#
// Modules/TestModule.cs
// Module exemple

namespace Modules;

class TestModule
{
    public static String toString()
    {
        return "Hello, World";
    }
}

```   
Import "direct":
```c#

// Program.cs
// Programme exemple

namespace TestApp;

internal class App
{
    private static void Main(string[] args)
    {
        // Affichage de la fonction toString de la class Modules/TestModule.cs
        // import avec `Namespace.Class.function`
        // dans ce cas, `using Modules n'est pas nécessaire`
        Console.WriteLine(Modules.TestModule.toString());
    }
}
```

import "indirect":
```c#

// Program.cs
namespace TestApp;
using Modules;

internal class App
{
    private static void Main(string[] args)
    {        
        // import avec using avec `Class.function`
        // Ici, using est nécesaire
        Console.WriteLine(TestModule.toString());
    }
}
```