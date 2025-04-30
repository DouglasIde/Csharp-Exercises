// Criar um dicionário que represente um aluno, com uma lista de notas,
// e mostre a média de suas notas na tela.
using System;
using System.Collections.Generic;
using System.Linq;

class Aluno {
    static void Main(){
        Dictionary<string, List<double>> aluno = new Dictionary<string, List<double>>();

        alunos.Add("Douglas", new List<double> { 7.5, 8.0, 9.0 });

        string nomeAluno = "Douglas";
        List<double> notas = alunos[nomeAluno];

        double media = notas.Average();

        Console.WriteLine($"A média das notas de {nomeAluno} é: {media}");
    }
}