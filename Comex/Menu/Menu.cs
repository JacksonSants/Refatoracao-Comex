using Comex;

namespace Comex.Menu;
internal abstract class Menu
{
    // Método que tem função de Exibir o Logo
    public static void ExibirLogo()
    {
        // mensagem de boas veindas do projeto
        string mensagemBoasVindas = "Boas vindas ao COMEX";

        Console.WriteLine(@"
────────────────────────────────────────────────────────────────────────────────────────
─██████████████─██████████████─██████──────────██████─██████████████─████████──████████─
─██░░░░░░░░░░██─██░░░░░░░░░░██─██░░██████████████░░██─██░░░░░░░░░░██─██░░░░██──██░░░░██─
─██░░██████████─██░░██████░░██─██░░░░░░░░░░░░░░░░░░██─██░░██████████─████░░██──██░░████─
─██░░██─────────██░░██──██░░██─██░░██████░░██████░░██─██░░██───────────██░░░░██░░░░██───
─██░░██─────────██░░██──██░░██─██░░██──██░░██──██░░██─██░░██████████───████░░░░░░████───
─██░░██─────────██░░██──██░░██─██░░██──██░░██──██░░██─██░░░░░░░░░░██─────██░░░░░░██─────
─██░░██─────────██░░██──██░░██─██░░██──██████──██░░██─██░░██████████───████░░░░░░████───
─██░░██─────────██░░██──██░░██─██░░██──────────██░░██─██░░██───────────██░░░░██░░░░██───
─██░░██████████─██░░██████░░██─██░░██──────────██░░██─██░░██████████─████░░██──██░░████─
─██░░░░░░░░░░██─██░░░░░░░░░░██─██░░██──────────██░░██─██░░░░░░░░░░██─██░░░░██──██░░░░██─
─██████████████─██████████████─██████──────────██████─██████████████─████████──████████─
────────────────────────────────────────────────────────────────────────────────────────");
        Console.WriteLine(mensagemBoasVindas);
    }
    //
    public static void ExibirOpcoesMenuPrincipal()
    {
        Console.WriteLine("\nDigite 1 Criar Produto");
        Console.WriteLine("Digite 2 Listar Produtos");
        Console.WriteLine("Digite 3 Consultar API Externa");
        Console.WriteLine("Digite 4 Ordenar Produtos pelo Título");
        Console.WriteLine("Digite 5 Ordenar Produtos pelo Preço");
        Console.WriteLine("Digite 6 Criar Pedido");
        Console.WriteLine("Digite 7 Listar Pedidos");
        Console.WriteLine("Digite -1 para sair");
    }
    public abstract Task ExecutarAsync(List<Produto> listaDeProdutos, List<Pedido> listaDePedidos);
}
