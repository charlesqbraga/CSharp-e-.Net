using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o projeto 07 - Condicionais");

        int idadeJoao = 16;
        int quantidadePessoa = 1;


        if (idadeJoao >= 18)
        {
            Console.WriteLine("Pode entrar!");
        }
        else  
        {
            if (quantidadePessoa >= 1)
                Console.WriteLine("Ele(a) está acompanhado(a), pode entrar.");
            else
            {
                Console.WriteLine("Não pode entrar");

            }
            
        }


        Console.WriteLine("Tecle Enter para fechar..");
        Console.ReadLine();
    }
}

