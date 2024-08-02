using Comex;

namespace Comex.Menu;

internal class MenuOrdernarPorPreco : Menu
{
    //Exibir produtos ordenados por preco
    public override async Task ExecutarAsync(List<Produto> listaDeProdutos, List<Pedido> listaDePedidos)
    {
        var produtosOrdenadosPorPreco = listaDeProdutos.OrderBy(p => p.PrecoUnitario).ToList();
        Console.Clear();
        Console.WriteLine("Produtos ordenados pelo preço:");
        for (int i = 0; i < produtosOrdenadosPorPreco.Count; i++)
        {
            Console.WriteLine($"Produto: {produtosOrdenadosPorPreco[i].Nome}, Preço: {produtosOrdenadosPorPreco[i].PrecoUnitario:F2}");
        }
        Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        await Task.CompletedTask;
    }
}
