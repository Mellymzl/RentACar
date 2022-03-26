using Core.Entities;
using NuGet.Protocol.Plugins;

namespace Core.CrossCuttingConcerns.Security.Jwt
{
    public interface ITokenHelper
    {
        AccessToken CreateToken(User user, List<Entities.OperationClaim> operationClaims);
    }
}
