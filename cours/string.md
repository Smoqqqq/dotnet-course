# STRINGS

## Concatenation

la concatenation est le fait de mettre "bout a bout" des chaines de caractères.  
pour former "Hello, World" avec les chaines "Hello" et "World" :

```C#
        String hello = "Chaine";
        String world = "assemblée";
        String greeting = hello + " " + world;
    // Affiche: 'Chaine assemblée'
    Console.WriteLine(greeting);
```

## Interpolation de chaines de caractères

l'interpolation est le fait d'assembler une chaine de caractères avec le résultat d'une expression C#
En C#, c'est l'opérateur '$' qui définit le début d'une chaine à interpoller.  
  
ex:
```C#
    Console.WriteLine($"toString de la classe 'App' : {toString()}");
```
ici, la chaine retourné par la fonction toString sera ajouté dans la chaine de caractères.  
la fonction toString() retournant 'Hello, World', le resultat sera le suivant :  
*toString de la classe 'App' : Hello, World*