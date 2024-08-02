using Comex;

namespace Comex.Menu;

internal class MenuOrdernarPorTitulo : Menu
{
    public override async Task ExecutarAsync(List<Produto> listaDeProdutos, List<Pedido> listaDePedidos)
    {
        //Exibir produtos ordenados por titulo
        var produtosOrdenados = listaDeProdutos.OrderBy(p => p.Nome).ToList();
        Console.Clear();
        Console.WriteLine("Produtos ordenados pelo título:");
        for (int i = 0; i < produtosOrdenados.Count; i++)
        {
            Console.WriteLine($"Produto: {produtosOrdenados[i].Nome}, Preço: {produtosOrdenados[i].PrecoUnitario:F2}");
        }
        Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        await Task.CompletedTask;
    }

}
