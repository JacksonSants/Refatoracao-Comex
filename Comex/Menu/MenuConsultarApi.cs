using Comex.Menu;
using Comex;

internal class MenuConsultarApi : Menu
{
    //Consultar api externa de produtos
    public override async Task ExecutarAsync(List<Produto> listaDeProdutos, List<Pedido> listaDePedidos)
    {
        using (HttpClient client = new HttpClient())
        {
            try
            {
                Console.WriteLine("\nExibindo Produtos\n");
                string resposta = await client.GetStringAsync("http://fakestoreapi.com/products");
                var produtos = System.Text.Json.JsonSerializer.Deserialize<List<Produto>>(resposta)!;
                for (int i = 0; i < produtos.Count; i++)
                {
                    Console.WriteLine($"Nome: {produtos[i].Nome}, " +
                        $"Descrição: {produtos[i].Descricao}, " +
                        $"Preço {produtos[i].PrecoUnitario} \n");
                }
                Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
                Console.ReadKey();
                Console.Clear();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Temos um problema: {ex.Message}");
            }
        }
    }
}
