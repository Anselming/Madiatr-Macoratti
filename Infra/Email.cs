public class Email: BaseEntity
{
    public string Corpo{ get; private set;}
    public Email(string corpo)
    {
        this.Corpo = corpo;
    }

    public void Send()
    {
        
    }
}