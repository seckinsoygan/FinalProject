namespace Core.Utilities.Security.JWT_Json_Web_Token_
{
    public class AccessToken
    {
        public string Token { get; set; }
        public DateTime Expiration { get; set; } //tokenin bitiş süresi

    }
}
