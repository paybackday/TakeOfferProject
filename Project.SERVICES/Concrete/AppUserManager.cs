using Project.CORE.DtoS;
using Project.CORE.Utilities.Abstract;
using Project.SERVICES.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.SERVICES.Concrete
{
    public class AppUserManager : IAppUserService
    {
        public Task<IDataResult<AppUserDto>> Get(int appUserId)
        {
            throw new NotImplementedException();
        }
    }
}
