using System;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        bool running = true;

        Console.WriteLine("Conexão estabelecida com o CLP.");
        while (running)
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1 - Ligar esteira");
            Console.WriteLine("2 - Desligar esteira");
            Console.WriteLine("3 - Monitorar sensores");
            Console.WriteLine("4 - Sair");
            Console.Write("Escolha uma opção: ");

            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    Console.WriteLine("Esteira ligada.");
                    break;
                case "2":
                    Console.WriteLine("Esteira desligada.");
                    break;
                case "3":
                    Console.WriteLine("Monitorando sensores...");
                    Thread.Sleep(1000);
                    Console.WriteLine("Sensor 1: Ativado");
                    Console.WriteLine("Sensor 2: Desativado");
                    break;
                case "4":
                    Console.WriteLine("Encerrando o sistema...");
                    running = false;
                    break;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        }
    }
}
