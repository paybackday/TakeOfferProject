using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAL.Abstract
{
    public interface IUnitOfWork:IAsyncDisposable
    {
        public IAppUserProfileRepository AppUserProfileRepository { get; }
        public IAppUserRepository AppUserRepository { get; }
        public ICategoryRepository CategoryRepository { get; }
        public ICommentRepository CommentRepository { get; }
        public IEventCommentRepository EventCommentRepository { get;}
        public IEventRepository EventRepository { get; }

        Task<int> SaveAsync();
    }
}
