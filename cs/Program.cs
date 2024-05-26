/*
    Comando para iniciar o projeto e, então, iniciar a programação: dotnet new console -o meuPrimeirPrograma
    See https://aka.ms/new-console-template for more information
*/
using System;

namespace HelloWorld
{
    class Hello {         
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("The current time is " + DateTime.Now);
        }
    }
}
