namespace Core.Utilities.Results
{
    public interface IDataResult<T> : IResult
    {
        //Interface içine interface implement ettiğimiz için diğer methodları yazmamıza gerek yok!
        T Data { get; }
    }
}
