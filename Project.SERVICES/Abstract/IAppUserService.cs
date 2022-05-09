using Project.CORE.DtoS;
using Project.CORE.Utilities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.SERVICES.Abstract
{
    public interface IAppUserService
    {
        Task<IDataResult<AppUserDto>> Get(int appUserId);
    }
}
