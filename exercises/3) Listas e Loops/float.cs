// Escrever uma função que a partir de 2 números de ponto flutuante A e B exiba no console o resultado
// de suas 4 operações matemáticas básicas (soma, subtração, multiplicação e divisão), utilizando a
// interpolação de strings.

using System;
class Program {

    static string Calculo(float a, float b){
        float soma = a + b;
        float subtracao = a - b;
        float multiplicacao = a * b;
        float divisao = a / b;

        return $"Soma: {soma}\nSubtração: {subtracao}\nMultiplicação: {multiplicacao}\nDivisão: {divisao}";
    }

    static void Main(string[] args){
        Console.WriteLine("Digite um número: ");
        float a = float.Parse(Console.ReadLine());

        Console.WriteLine("Digite outro número: ");
        float b = float.Parse(Console.ReadLine());

        string resultado = Calculo(a, b);
        Console.WriteLine(resultado);
    }
}