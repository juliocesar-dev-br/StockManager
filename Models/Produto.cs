class Produto
{
    public int Id {get; private set;}
    public string Nome {get; private set;} = string.Empty;
    public decimal Preco {get; private set;}
    public int Quantidade {get; private set;}
    public string Categoria {get; private set;} = string.Empty;


    public Produto(int id, string nome, decimal preco, int quantidade, string categoria)
    {
        Id = id;
        Nome = nome;
        Preco = preco;
        Quantidade = quantidade;
        Categoria = categoria;
    }

    public override string ToString()
    {
        return $"Id: {Id} | Nome: {Nome} | Preço: {Preco} | Quantidade: {Quantidade} | Categoria: {Categoria}";
    }

    public string AdicionarQuantidade(int quantidade)
    {
        if(quantidade > 0)
        {
            Quantidade += quantidade;
            return $"{quantidade} unidades foram adicionadas no estoque!";
        }
     
            return "A quantidade a ser adicionada deve ser maior que zero!";
        
    }

    public string RemoverQuantidade(int quantidade)
    {
        if(quantidade > 0 && quantidade <= Quantidade)
        {
            Quantidade -= quantidade;
            return $"{quantidade} unidades foram removidas do estoque!";
        }
        else if(quantidade < 0)
        {
            return "A quantidade a ser removida deve ser maior que zero!";
        }
        else
        {
            return "A quantidade solicitada para retirada deve ser menor ou igual a quantidade no estoque!";
        }
        
    }

}