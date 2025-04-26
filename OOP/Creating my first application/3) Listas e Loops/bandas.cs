// 2 - Criar uma lista de bandas vazias e adicionar suas bandas prediletas em seguida;
// 3 - Utilizar a estrutura FOR para mostrar todas as suas bandas preferidas no console.
using System;
using System.Collections.Generic;

class Bandas {
    static void Main(){
        List<string> bandas = new List<string>();

        bandas.Add("Blink 182");
        bandas.Add("Sum 41");
        bandas.Add("A Day to Remember");
        bandas.Add("Green Day");

        foreach(string banda in bandas){
            Console.WriteLine(banda);
        }
    }
}