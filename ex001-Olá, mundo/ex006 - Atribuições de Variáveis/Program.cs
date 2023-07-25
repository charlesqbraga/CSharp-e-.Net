using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando projeto 06 - Atribuições de variáveis.");

        int idade = 30;
        int idadeAna = idade;
        Console.WriteLine(idadeAna);


        idade = 60;
        Console.WriteLine(idade);

        Console.WriteLine("Tecle Enter para fechar..");
        Console.ReadLine();
    }
}
