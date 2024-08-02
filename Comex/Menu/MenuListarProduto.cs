using Comex;

namespace Comex.Menu;

internal class MenuListarProduto : Menu
{
    public override async Task ExecutarAsync(List<Produto> listaDeProdutos, List<Pedido> listaDePedidos)
    {
        //Exibir todos os produtos registrados
        Console.Clear();
        Console.WriteLine("Exibindo todos os produtos registradoss na nossa aplicação");

        for (int i = 0; i < listaDeProdutos.Count; i++)
        {
            Console.WriteLine($"Produto: {listaDeProdutos[i].Nome}, Preço: {listaDeProdutos[i].PrecoUnitario:F2}");
        }

        Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        await Task.CompletedTask;
    }

}
