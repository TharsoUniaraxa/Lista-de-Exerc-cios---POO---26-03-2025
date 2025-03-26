using System;

class Program
{
    static void Main()
    {
        Lampada lampada = new Lampada();
        int opcao;

        do
        {
            Console.WriteLine("\nMenu da Lâmpada:");
            Console.WriteLine("1 - Ligar a lâmpada");
            Console.WriteLine("2 - Desligar a lâmpada");
            Console.WriteLine("3 - Mostrar estado da lâmpada");
            Console.WriteLine("0 - Sair");
            Console.Write("Escolha uma opção: ");

            if (int.TryParse(Console.ReadLine(), out opcao))
            {
                switch (opcao)
                {
                    case 1:
                        lampada.Ligar();
                        break;
                    case 2:
                        lampada.Desligar();
                        break;
                    case 3:
                        lampada.MostrarEstado();
                        break;
                    case 0:
                        Console.WriteLine("Saindo do programa...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida! Tente novamente.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Entrada inválida! Digite um número.");
            }
        } while (opcao != 0);
    }
}