// Criar um programa que gerencie o estoque de uma loja. Utilizando um dicionário, para armazenar produtos
// e suas quantidades em estoque e mostre, a partir do nome de um produto, sua quantidade em estoque.
using System;
using System.Collections.Generic;

class Program {
    static void Main(){
        Dictionary<string, int> estoque = new Dictionary<string, int>();

        estoque.Add("Camiseta", 45);
        estoque.Add("Calça", 30);
        estoque.Add("Tênis", 20);
        estoque.Add("Boné", 15);

        Console.WriteLine("Digite o nome do produto que deseja verificar a quantidade em estoque:");
        string produto = Console.ReadLine();

        if(estoque.ContainsKey(produto)){
            Console.WriteLine($"A quantidade em estoque de {produto} é: {estoque[produto]}");
        } else {
            Console.WriteLine($"O produto {produto} não está disponível no estoque.");
        }
    }
}