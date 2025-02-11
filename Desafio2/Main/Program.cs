﻿using System;
using System.Runtime.Intrinsics;

internal class Program
{
    private static void Main(string[] args) 
    { 
        Loja loja = new Loja("Americanas", "12345678910123");

        Livro l1 = new Livro("Harry Potter", 40, 50, "J. K. Rowling", "fantasia", 300);
        Livro l2 = new Livro("Senhor dos Anéis", 60, 30, "J. R. R. Tolkien", "fantasia", 500);
        Livro l3 = new Livro("Atlas", 20, 50, "Anonimo", "educativo", 250);

        VideoGame ps5 = new VideoGame("PS5", 1800, 100, "Sony", "Slim", false);
        VideoGame ps5Usado = new VideoGame("PS5", 1000, 7, "Sony", "Slim", true);
        VideoGame xbox = new VideoGame("XBOX", 1500, 500, "Microsoft", "Series-X", false);

        loja.AdicionarLivro(l1);
        loja.AdicionarLivro(l2);
        loja.AdicionarLivro(l3);
        loja.AdicionarVideoGame(ps5);
        loja.AdicionarVideoGame(ps5Usado);
        loja.AdicionarVideoGame(xbox);

        Console.WriteLine("\n-----------------------------------------------------------------------------------------------------------");
        l1.calculaImposto();
        l3.calculaImposto();
        ps5.calculaImposto();
        ps5Usado.calculaImposto();
        Console.WriteLine("\n-----------------------------------------------------------------------------------------------------------");
        loja.ListaLivros();
        Console.WriteLine("\n-----------------------------------------------------------------------------------------------------------");
        loja.ListaVideoGames();
        Console.WriteLine("\n-----------------------------------------------------------------------------------------------------------");
        Console.WriteLine($"\nO patrimonio da loja: {loja.Nome} é de R$ {loja.calculaPatrimonio()}");
    }
}
