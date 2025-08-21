namespace ExampleProjectDDD.Shared.Abstraction.Queries
{
    //Inteface Marker
    public interface IQuery
    {
    }
    public interface IQuery<TResult>:IQuery
    {
    }
}
