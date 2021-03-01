using JwelryBackendSide.DatabaseLayer.BaseRepository;
using JwelryBackendSide.DatabaseLayer.Entity;
using JwelryBackendSide.Modals.Request;
using JwelryBackendSide.Modals.Response;
using System.Threading.Tasks;

namespace JwelryBackendSide.Abstraction.RepositoryLayer
{
    public interface IJwelryRepository : IBaseRepository<UserLogin>
    {
        Task<UserInformation> UserLoginInfo(UserLoginRequest userLoginRequest);
    }
}
