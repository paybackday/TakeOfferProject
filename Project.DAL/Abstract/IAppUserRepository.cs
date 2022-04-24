﻿using Project.CORE.Dal.Abstract;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAL.Abstract
{
    public interface IAppUserRepository:IEntityRepository<AppUser>
    {
    }
}
