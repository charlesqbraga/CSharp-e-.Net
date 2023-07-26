using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o projeto 07 - Condicionais");

        int idadeJoao = 16;
        int quantidadePessoa = 2;

        bool acompanhado = quantidadePessoa > 1;
        bool grupo = true;


        if (idadeJoao >= 18 || acompanhado)
        {
            Console.WriteLine("Pode entrar!");
        }
        else
        {
            Console.WriteLine("Não pode entrar");
        }




        Console.WriteLine("Tecle Enter para fechar..");
        Console.ReadLine();
    }
}
