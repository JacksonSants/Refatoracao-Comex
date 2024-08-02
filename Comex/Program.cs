// See https://aka.ms/new-console-template for more information
using Comex;
using Comex.Menu;

// lstpt = lista de produtos para ser utilizada durante os testes
var listaDeProdutos = new List<Produto>
{
    new Produto("Notebook")
    {
        Descricao = "Notebook Dell Inspiron",
        PrecoUnitario = 3500.00,
        Quantidade = 10
    },
    new Produto("Smartphone")
    {
        Descricao = "Smartphone Samsung Galaxy",
        PrecoUnitario = 1200.00,
        Quantidade = 25
    },
    new Produto("Monitor")
    {
        Descricao = "Monitor LG Ultrawide",
        PrecoUnitario = 800.00,
        Quantidade = 15
    },
    new Produto("Teclado")
    {
        Descricao = "Teclado Mecânico RGB",
        PrecoUnitario = 250.00,
        Quantidade = 50
    }
};
// ltspd = lista de pedidos para ser utilizada durante os testes
var listaDePedidos = new List<Pedido>();

var opcoesMenu = new Dictionary<int, Menu>
{
    { 1, new MenuRegistrarProduto() },
    { 2, new MenuListarProduto()},
    { 3, new MenuConsultarApi()},
    { 4, new MenuOrdernarPorTitulo()},
    { 5, new MenuOrdernarPorPreco()},
    { 6, new MenuCriarPedido()},
    { 7, new MenuListarPedido()},
    { -1, new MenuSair()}
};

// Método que tem função de Exibir Opcoes Do Menu
async Task ExibirOpcaoMenu()
{
    Menu.ExibirLogo();
    Menu.ExibirOpcoesMenuPrincipal();

    Console.Write("\nDigite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;

    // Verificar se a opção escolhida é válida e tratar exceções
    if (int.TryParse(opcaoEscolhida, out int opcaoEscolhidaNumerica) && opcoesMenu.ContainsKey(opcaoEscolhidaNumerica))
    {
        // Executar o menu escolhido
        await opcoesMenu[opcaoEscolhidaNumerica].ExecutarAsync(listaDeProdutos, listaDePedidos);

        // Continuar o menu se a opção não for para sair
        if (opcaoEscolhidaNumerica != -1)
        {
            await ExibirOpcaoMenu(); // Usar await para garantir que o menu será exibido novamente
        }
    }
    else
    {
        Console.WriteLine("Opção inválida, tente novamente.");
        await ExibirOpcaoMenu(); // Reexibir o menu se a opção for inválida
    }
}

await ExibirOpcaoMenu();