// DESAFIO: Utilizar o conceito de laço de repetição "do-while" para permitir que o usuário
// faça várias tentativas até acertar o número.
// Quando o usuário acertar o número, o jogo acaba e o programa exibe uma mensagem indicando que o jogo acabou.

using System;
using System.Collections.Generic;

Random random = new Random();
int numeroAleatorio = random.Next(1, 101);
string user_answer;

do
{
    Console.WriteLine("Tenta a sorte em adivinhar o número que estou pensando!");
    user_answer = Console.ReadLine();
    int answer = int.Parse(user_answer);

    if(answer == numeroAleatorio)
    {
        Console.WriteLine("Parabéns!! Você acertou!!");
        break;
    } else if (answer < numeroAleatorio){
        Console.WriteLine("Errou! Tente um número MAIOR");
    } else {
        Console.WriteLine("Errou! Tente um número MENOR");
    }
} while(true);


