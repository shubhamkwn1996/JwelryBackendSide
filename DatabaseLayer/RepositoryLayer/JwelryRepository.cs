using JwelryBackendSide.Abstraction.RepositoryLayer;
using JwelryBackendSide.DatabaseLayer.BaseRepository;
using JwelryBackendSide.DatabaseLayer.Entity;
using JwelryBackendSide.Modals.Request;
using JwelryBackendSide.Modals.Response;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace JwelryBackendSide.DatabaseLayer.RepositoryLayer
{
    public class JwelryRepository : BaseRepository<UserLogin, ApplicationDbContext>, IJwelryRepository
    {
        private readonly ApplicationDbContext dbContext;
        public JwelryRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<UserInformation> UserLoginInfo(UserLoginRequest userLoginRequest)
        {
            UserInformation result = null;


            var res = await dbContext.UserLogin.Where(x => x.UserName == userLoginRequest.UserName && x.Password == userLoginRequest.Password).FirstOrDefaultAsync();
            if (res != null)
            {
                result = new UserInformation()
                {
                    UserId = res.UserId,
                    UserName = res.UserName,
                    UserType = res.UserType
                };
            }
            return result;
        }
    }
}
