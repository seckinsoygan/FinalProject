namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        public Result(bool success, string message) : this(success) //Buradaki this sadece tek refin gönderildiği constructorında çalışmasını sağlıyor.
        {
            //Success = success;
            Message = message;
        }

        public Result(bool success)
        {
            Success = success;
        }

        public bool Success { get; }
        public string Message { get; }
    }
}
