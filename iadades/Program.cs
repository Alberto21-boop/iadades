﻿namespace idades;

public class Program
{
    static void Main(string[] args)
    {
        //Fazer um programa para ler o nome e idade de duas pessoas. Ao final mostrar uma mensagem com os nomes e
        //a idade media entre essas pessoas.

        string nome1, nome2;
        double idade1, idade2, media;
        

        Console.WriteLine("Entre com os dados da primeira pessoa");
        Console.Write("Nome: ");
        nome1 = Console.ReadLine();
        Console.WriteLine("Agora entre com a idade da pessoa");
        Console.Write("Idade: ");
        idade1 = int.Parse(Console.ReadLine());
        
        Console.WriteLine();
        
        Console.WriteLine("Agora entre com os dados da segunda pessoa");
        Console.Write("Nome ");
        nome2 = Console.ReadLine();
        Console.WriteLine("Agora entre com a idade da segunda pessoa");
        Console.Write("Idade: ");
        idade2 = int.Parse(Console.ReadLine());

        media = (idade1 + idade2) / 2;

        Console.WriteLine("A idade media entre " + nome1 + " e " + nome2 + " é de = " + media + " anos" );
        

    }
}