public class Produto: BaseEntity
{
    public Guid Id{get; private set;}
    public string Nome{get; private set;}
    public decimal Price {get;private set;}

    public Produto(string nome, decimal price)
    {
        this.Id = Guid.NewGuid();
        this.Nome = nome;
        this.Price = price;
    }

    public void RegistrarNovoProduto()
    {
        this._mediator.Notify(this, "Produto comprado");
    }
}