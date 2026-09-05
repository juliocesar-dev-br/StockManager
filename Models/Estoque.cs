class Estoque
{
    private  readonly List<Produto> produtos = new();

    public string CadastrarProduto(Produto produto)
    {
        for(int i = 0; i < produtos.Count; i++)
        {
            if(produtos[i].Id == produto.Id)
            {
                return "Error! Ids repetidos não são aceitos";
    
            }
        }
        
        produtos.Add(produto);
        return "Produto cadastrado com sucesso!";
    }

    public void ListarProdutos()
    {
        if(produtos.Count > 0)
        {
            foreach(Produto produto in produtos)
            {
                System.Console.WriteLine(produto);
            }
        }
       
        System.Console.WriteLine("Não há produtos cadastrados no estoque");
        return;
        
    }
}