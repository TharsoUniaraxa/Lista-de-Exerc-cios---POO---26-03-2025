using System;

class Program
{
    static void Main(string[] args)
    {
        Contabancaria conta = new Contabancaria();

            
        int opcao = 0;

        while (opcao != 4) 
        {


            Console.WriteLine("Opções:");
            Console.WriteLine("1 - Depósito");
            Console.WriteLine("2 - Saque");
            Console.WriteLine("3 - Exibir saldo");

            Console.Write("Escolha uma opção: ");
            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Console.Write("Digite o valor do deposito: ");
                    double valorDeposito = double.Parse(Console.ReadLine());
                    conta.Depositar(valorDeposito);
                    break;
                    
                case 2:
                    Console.Write("Digite o valor do saque: ");
                    double valorSaque = double.Parse(Console.ReadLine());
                    conta.sacar(valorSaque);
                    break;
                case 3:
                    conta.exibir();
                    break;
                default:
                    Console.WriteLine("tente outra opção");
                    break;

            }

        } 
    }
}
