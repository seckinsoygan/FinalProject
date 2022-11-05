using Core.Entities.Concrete;

namespace Core.Utilities.Security.JWT_Json_Web_Token_
{
    public interface ITokenHelper
    {
        AccessToken CreateToken(User user, List<OperationClaim> operationClaims);

    }
}
