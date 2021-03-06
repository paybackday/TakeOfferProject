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
    public class EventCommentRepository:EfEntityRepository<EventComment>,IEventCommentRepository
    {
        public EventCommentRepository(MyContext context):base(context)
        {

        }
    }
}
