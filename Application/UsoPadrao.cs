public class UsoPadrao
{
    public UsoPadrao()
    {
        Produto p = new Produto("Chinelo", 50);
        Email e = new Email("Produto criado com sucesso");
        Log l = new Log($"Criação do produto em {DateTime.Now}");

        Mediator m = new Mediator(p, e, l );
        m.Notify(p, "Boa");
    }
}