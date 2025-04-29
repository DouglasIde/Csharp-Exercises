// Crie um programa que implemente um quiz simples de perguntas e respostas
// Utilize um dicionário para armazenar as perguntas e as respostas corretas
// Douglas: No meu caso só queria comparar as respostas com as respostas corretas, elas não são armazenadas!!
using System;
using System.Collections.Generic;

class Quiz {
    static void Main(){
        Dictionary<string, string> questions = new Dictionary<string, string>(){
            {"Qual é o maior mandamento segundo Jesus?", "Amar a Deus acima de todas as coisas"},
            {"Quantos dias Deus levou para criar o mundo?", "6"},
            {"Quem negou Jesus 3 vezes?", "Pedro"},
            {"Qual é o último livro da Bíblia?", "Apocalipse"},
            {"Quem foi escolhido para substituir Judas como apóstolo?", "Matias"}
        };

        int score = 0;

        foreach(var question in questions){
            // Exibe a pergunta e depois a resposta do usuário
            Console.WriteLine(question.Key);
            string answer = Console.ReadLine();

            // Verifica se a resposta está correta
            if(answer.Equals(question.Value, StringComparison.OrdinalIgnoreCase)){
                Console.WriteLine("Correto!!");
                score++;
            } else {
                Console.WriteLine($"Errado!! A resposta correta é {question.Value}");
            }

            Console.Clear();
            Console.WriteLine($"Você acertou {score} de {questions.Count} perguntas.");
        }


    }
}