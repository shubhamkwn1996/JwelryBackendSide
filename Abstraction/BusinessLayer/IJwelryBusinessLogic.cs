using JwelryBackendSide.Modals.Request;
using JwelryBackendSide.Modals.Response;
using System.Threading.Tasks;

namespace JwelryBackendSide.Abstraction.BusinessLayer
{
    public interface IJwelryBusinessLogic
    {
        Task<UserInformation> UserLogin(UserLoginRequest userLoginRequest);
    }
}
