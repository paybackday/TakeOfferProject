using Project.CORE.Dal.Concrete.EntityFramework;
using Project.DAL.Abstract;
using Project.DAL.Concrete.EntityFramework.Context;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAL.Concrete.EntityFramework.Repositories
{
    public class AppUserProfileRepository:EfEntityRepository<AppUserProfile>,IAppUserProfileRepository
    {
        public AppUserProfileRepository(MyContext context):base(context)
        {

        }
    }
}
