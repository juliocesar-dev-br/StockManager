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
        else
        {
            System.Console.WriteLine("Não há produtos cadastrados no estoque");
        }
       
        return;
        
    }

    public Produto? BuscarProdutoPorId(int id)
    {
        foreach(Produto produto in produtos)
        {
            if(produto.Id == id)
            {
                return produto;
            }
        }

        return null;
    }

    public void RemoverProdutoPorId(int id)
    {
       
        Produto? produto = BuscarProdutoPorId(id);

        if(produto != null)
        {
            produtos.Remove(produto);
            Console.WriteLine($"Produto: {produto.Nome} -> removido com sucesso");
            return;
        }

        Console.WriteLine($"ID: {id} não foi encontrado!");  
    }

}