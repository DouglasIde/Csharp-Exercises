// Criar um programa que calcula a soma de todos os elementos inteiros em uma lista
using System;
using System.Collections.Generic;

class Program {

    // Função que faz a soma de todos os elementos na lista
    static int Soma(List<int> numeros){
        int soma = 0;

        foreach(int numero in numeros){
            soma += numero;
        }

        return soma;
    }

    static void Main(string[] args){
        List<int> numeros = new List<int>{3, 10, 9, 2, 49};

        int soma = Soma(numeros);

        Console.WriteLine($"A soma de todos os elementos da lista é: {soma}");
    }
}