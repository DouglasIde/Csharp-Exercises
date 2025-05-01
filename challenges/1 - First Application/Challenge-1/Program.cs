Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();
bandasRegistradas.Add("Linkin Park", new List<int> { 10, 8, 6 });
bandasRegistradas.Add("The Beatles", new List<int>());

void ExibirLogo()
{
    Console.WriteLine("WELCOME TO THE SCREEN SOUND");
}

void ExibirOpcoesDoMenu()
{
    ExibirLogo();
    Console.WriteLine(@"
        1 - Registrar uma banda
        2 - Mostrar todas as bandas
        3 - Avaliar uma banda
        4 - Exibir a média de uma banda
        -1 - Sair

        Digite a sua opção:
    ");

    string opcaoEscolhida = Console.ReadLine();
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    switch (opcaoEscolhidaNumerica)
    {
        case 1:
            RegistrarBanda();
            break;
        case 2:
            MostrarBandaRegistrada();
            break;
        case 3:
            AvaliarBanda();
            break;
        case 4:
            ExibirMedia();
            break;
        case -1:
            Console.WriteLine("Até logo!!");
            break;
        default:
            Console.WriteLine("Opção inválida!");
            break;
    }
}

void ExibirTituloOpcao(string titulo)
{
    int qtd_Letras = titulo.Length;
    string asteriscos = string.Empty.PadLeft(qtd_Letras, '*');
    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteriscos + "\n");
}

void RegistrarBanda()
{
    Console.Clear();
    ExibirTituloOpcao("Registro de Bandas");
    Console.WriteLine("Digite o nome da banda que deseja registrar: ");
    string nome_banda = Console.ReadLine();

    bandasRegistradas.Add(nome_banda, new List<int>());
    Console.WriteLine($"A banda {nome_banda} foi registrada com sucesso!");
    Thread.Sleep(4000);
    Console.Clear();
    ExibirOpcoesDoMenu();
}

void MostrarBandaRegistrada()
{
    Console.Clear();
    ExibirTituloOpcao("Exibindo todas as bandas registradas na nossa aplicação");

    foreach(string banda in bandasRegistradas.Keys)
    {
        Console.WriteLine($"Banda: {banda}");
    }

    Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu();
}

void AvaliarBanda()
{
    Console.Clear();
    ExibirTituloOpcao("Avaliar banda");
    Console.WriteLine("Digite o nome da banda que deseja avaliar: ");
    string nome_banda = Console.ReadLine();

    if (bandasRegistradas.ContainsKey(nome_banda))
    {
        Console.WriteLine($"Qual a nota que a banda {nome_banda} merece: ");
        int nota = int.Parse(Console.ReadLine()!);
        bandasRegistradas[nome_banda].Add(nota);

        Console.WriteLine($"\nA nota {nota} foi registrada com sucesso para a banda {nome_banda}");
        Thread.Sleep(2000);
        Console.Clear();
        ExibirOpcoesDoMenu();
    } else
    {
        Console.WriteLine($"\nA banda {nome_banda} não foi encontrada!");
        Console.WriteLine("Digite uma tecla para voltar para o menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
}

void ExibirMedia()
{
    Console.Clear();
    ExibirTituloOpcao("Exibindo a média da banda");
    Console.WriteLine("Digite a banda a qual deseja visualizar a média: ");
    string nome_banda = Console.ReadLine();

    if (bandasRegistradas.ContainsKey(nome_banda))
    {
        double media = bandasRegistradas[nome_banda].Average();
        Console.WriteLine($"A média da banda {nome_banda} é {media}");
    } else
    {
        Console.WriteLine($"A banda {nome_banda} não possui avaliação!!");
    }

    Console.WriteLine($"\nA banda {nome_banda} não foi encontrada!");
    Console.WriteLine("Digite uma tecla para voltar para o menu principal");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu();
}

ExibirOpcoesDoMenu();