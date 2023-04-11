public abstract class BaseEntity
{
    private IMediator _mediator;

    public BaseEntity(IMediator mediator = null)
    {
        this._mediator = mediator;
    }

    public void SetMediator(IMediator mediator) => this._mediator = mediator;

    protected void Notify(string message)
    {
        this._mediator.Notify(this, message);
    }

}