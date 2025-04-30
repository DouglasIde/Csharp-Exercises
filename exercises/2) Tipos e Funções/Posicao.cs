// Crie um programa que, dado a entrada de dados
// de um número N inteiro, a partir do teclado, exibir
// a n-ésima posição de uma lista

// Criando a lista
List<int> numeros = new List<int>();

// Loop com a entrada de dados até 10 números
for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Digite um número inteiro:");
    int numero = Convert.ToInt32(Console.ReadLine());
    numeros.Add(numero);
}

// Interação com o usuário sobre a posição desejada
Console.WriteLine("Digite a posição que deseja exibir:");
int posicao = int.Parse(Console.ReadLine());

// Verifica se a posição é válida
Console.WriteLine(posicao + "ª posição: " + numeros[posicao - 1]);