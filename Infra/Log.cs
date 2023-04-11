public class Log: BaseEntity
{
    public string LogText{ get; private set;}
    public Log(string log)
    {
        this.LogText = log;
    }

    public void RegisterLog()
    {

    }
}