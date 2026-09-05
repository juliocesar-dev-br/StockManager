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
}