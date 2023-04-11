public class Mediator :IMediator
{
    public Produto Produto;
    public Email Email;
    public Log Log;

    public Mediator(Produto produto, Email email, Log log)
    {
        this.Produto = produto;
        this.Produto.SetMediator(this);

        this.Email = email;
        this.Email.SetMediator(this);

        this.Log = log;
        this.Log.SetMediator(this);
    }

    public void Notify(object sender, string args)
    {
        if(sender is Produto)
        {
            Email.Send();
            Log.RegisterLog();
        }

        if(sender is Email)
            Log.RegisterLog();

        if(sender is Log)
        {
            
        }

    }
}