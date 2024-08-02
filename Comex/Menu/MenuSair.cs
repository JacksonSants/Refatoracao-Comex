using Comex;
namespace Comex.Menu;

internal class MenuSair : Menu
{
    //Sair da aplicação
    public override async Task ExecutarAsync(List<Produto> listaDeProdutos, List<Pedido> listaDePedidos)
    {

        Console.WriteLine("Tchau tchau :)");
        await Task.CompletedTask;
    }
}
