using JwelryBackendSide.Abstraction.BusinessLayer;
using JwelryBackendSide.Abstraction.RepositoryLayer;
using JwelryBackendSide.Modals.Request;
using JwelryBackendSide.Modals.Response;
using System.Threading.Tasks;

namespace JwelryBackendSide.BusinessLayer
{
    public class JwelryBusinessLogic : IJwelryBusinessLogic
    {
        private readonly IJwelryRepository _jwelryRepository;
        public JwelryBusinessLogic(IJwelryRepository jwelryRepository)
        {
            _jwelryRepository = jwelryRepository;
        }

        public async Task<UserInformation> UserLogin(UserLoginRequest userLoginRequest)
        {
            var result = await _jwelryRepository.UserLoginInfo(userLoginRequest);
            return result;
        }
    }
}
