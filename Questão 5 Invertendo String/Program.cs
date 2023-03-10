using System;

class Program
{
    //Questão 5 - Invertendo String
    static void Main()
    {

        string caracteres = "";
        string inversao = "";

        Console.WriteLine("Insira uma sequência de caracteres: ");
        caracteres = Console.ReadLine();

        for (int i = caracteres.Length - 1; i >= 0; i--)
        {
            inversao += caracteres[i];
        }

        Console.WriteLine(inversao);


        Console.ReadLine();
    }
}