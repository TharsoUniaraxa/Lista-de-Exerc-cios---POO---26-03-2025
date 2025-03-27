using System;

class Program





{

    static void Main()

    {
        Produto produto = new Produto();



        Console.Write("escreva o produto: ");
        produto.nome = Console.ReadLine();
        Console.Write("escreva o preço: ");
        produto.preço = Convert.ToDouble(Console.ReadLine());
        Console.Write("escreva a quantidade do estoque: ");
        produto.quantidade = int.Parse(Console.ReadLine());



        while (true)


        {
            Console.WriteLine("Escolha uma opçao:");
            Console.WriteLine("1 = Adicionar ao estoque");
            Console.WriteLine("2 = Remover do estoque");
            Console.WriteLine("3 = Exibir detalhes");
            int opcao = int.Parse(Console.ReadLine());


            if (opcao == 1)

            {

                Console.Write("Digite a quantidade que você deseja adicionar ao estoque: ");
                int quantidade = int.Parse(Console.ReadLine());
                produto.adicionarestoque(quantidade);

            }
            else if (opcao == 2)
            {
                Console.Write("Digite a quantidade que você deseja remover do estoque: ");


                int quantidade = int.Parse(Console.ReadLine());
                produto.removerestoque(quantidade);
            }
            else if (opcao == 3)
            {
                produto.exibirdetalhes();
            }
        }
    }
}