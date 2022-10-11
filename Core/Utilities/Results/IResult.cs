namespace Core.Utilities.Results
{
    //Temel voidler için başlangıç
    public interface IResult
    {
        bool Success { get; } //İşlem başarılı mı değil mi onun yönlendirmesini kontrol eder. True-False
        string Message { get; } //İşlemin başarılı olup olmama durumuna göre message verir.
    }
}
