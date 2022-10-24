# Conditions ternaires
une ternaires est une condition 'if/else':

```c#
    // Affiche: majeur: False
    Int16 age = 17;
    // Définition de la variable      condition    si vrai      si faux
    Boolean majeur                  = (age > 18) ? true    :    false;
    Console.WriteLine($"majeur: {majeur}");

    // Affiche: majeur: true
    Int16 age2 = 28;
    Boolean majeur2 = (age > 18) ? true : false;
    Console.WriteLine($"majeur: {majeur2}");
```