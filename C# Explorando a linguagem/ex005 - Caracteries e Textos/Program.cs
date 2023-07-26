using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o projeo 05 - Caractéries e textos.");

        char letra = 'a';
        Console.WriteLine(letra);

        letra = (char)65;
        Console.WriteLine(letra);

        letra = (char)(65 + 1);
        Console.WriteLine(letra);

        string primeiraFrase = "Olá, mundo!!! ";
        Console.WriteLine(primeiraFrase + 2023);

        string cursos = @"Cursos disponiveis:
- C#
- Python
- JavaScript
- Java";
        Console.WriteLine(cursos);



        Console.WriteLine("Tecle Enter para fechar..");
        Console.ReadLine();
    }
}