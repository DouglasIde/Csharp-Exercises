// Criar um programa que simule um sistema de login utilizando um dicionário para armazenar
// nomes de usuário e senhas.
using System;
using System.Collections.Generic;

class Login {
    static Dictionary<string, string> users = new Dictionary<string, string>(){
        {"exemplo01@gmail.com", "390rjn20i"},
        {"teste@gmail.com", "0f23nanI3"},
        {"cristiano_ronaldo@gmail.com", "HalaMadrid!"},
        {"JesusVive@gmail.com", "EleVivePossoCrerNoAmanha"}
    };

    static void Main() {
        int opcao;

        do {
            Console.WriteLine(@"
            Escolha uma opção:
            1. Criar Conta
            2. Fazer Login
            0. Sair
            ");

            if (!int.TryParse(Console.ReadLine(), out opcao)) {
                Console.WriteLine("Digite um número válido!");
                continue;
            }

            switch (opcao) {
                case 1:
                    CriarConta();
                    break;
                case 2:
                    FazerLogin();
                    break;
                case 0:
                    Console.WriteLine("Saindo...");
                    break;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        } while (opcao != 0);
    }

    static void CriarConta() {
        Console.WriteLine("Digite seu e-mail:");
        string login = Console.ReadLine();

        if (users.ContainsKey(login)) {
            Console.WriteLine("E-mail já cadastrado. Tente novamente.");
            return;
        }

        Console.WriteLine("Digite sua senha:");
        string senha = Console.ReadLine();

        users.Add(login, senha);
        Console.WriteLine("Conta criada com sucesso!");
    }

    static void FazerLogin() {
        Console.WriteLine("Digite seu e-mail: ");
        string login = Console.ReadLine();

        Console.WriteLine("Digite sua senha: ");
        string senha = Console.ReadLine();

        if (users.ContainsKey(login)) {
            if (users[login] == senha) {
                Console.WriteLine("Login realizado com sucesso!");
            } else {
                Console.WriteLine("Senha incorreta. Tente novamente.");
            }
        } else {
            Console.WriteLine("E-mail não cadastrado. Tente novamente.");
        }
    }
}