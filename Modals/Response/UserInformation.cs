using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JwelryBackendSide.Modals.Response
{
    public class UserInformation
    {
        public string UserName { get; set; }
        public Int64 UserId { get; set; }

        public string UserType { get; set; }
    }
}
