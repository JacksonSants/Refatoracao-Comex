using Comex;

namespace Comex.Menu;
internal class MenuListarPedido : Menu
{
    //Exibir todos os pedidos registrados
    public override async Task ExecutarAsync(List<Produto> listaDeProdutos, List<Pedido> listaDePedidos)
    {
        Console.Clear();
        Console.WriteLine("Exibindo todos os produtos registradoss na nossa aplicação");

        var pedidosOrdenados = listaDePedidos.OrderBy(p => p.Cliente.Nome).ToList();

        if (pedidosOrdenados.Count > 0)
        {
            foreach (var Pedido in pedidosOrdenados)
            {
                Console.WriteLine($"Cliente: {Pedido.Cliente.Nome}, Total: {Pedido.Total:F2}");
            }

        }
        else
        {
            Console.WriteLine("Nenhum pedido foi encontrado.");
        }

        Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        await Task.CompletedTask;
    }

}
