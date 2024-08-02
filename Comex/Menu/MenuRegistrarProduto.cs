using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Comex;

namespace Comex.Menu;

internal class MenuRegistrarProduto : Menu
{
    //Registrar um produto
    public override async Task ExecutarAsync(List<Produto> listaDeProdutos, List<Pedido> listaDePedidos)
    {
        Console.Clear();
        Console.WriteLine("Registro de Produto");

        Console.Write("Digite o nome do Produto: ");
        string nomeDoProduto = Console.ReadLine();
        var produto = new Produto(nomeDoProduto);

        Console.Write("Digite a descrição do Produto: ");
        string descricaoDoProduto = Console.ReadLine();
        produto.Descricao = descricaoDoProduto;

        Console.Write("Digite o preço do Produto: ");
        string precoDoProduto = Console.ReadLine();
        produto.PrecoUnitario = double.Parse(precoDoProduto);

        Console.Write("Digite a quantidade do Produto: ");
        string quantidadeDoProduto = Console.ReadLine();
        produto.Quantidade = int.Parse(quantidadeDoProduto);

        listaDeProdutos.Add(produto);
        Console.WriteLine($"O Produto {produto.Nome} foi registrado com sucesso!");

        Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();

        await Task.CompletedTask;
    }
}
