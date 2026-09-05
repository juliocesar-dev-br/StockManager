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

}