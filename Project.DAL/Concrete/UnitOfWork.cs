using Project.DAL.Abstract;
using Project.DAL.Concrete.EntityFramework.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAL.Concrete
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly MyContext _context;
        public IAppUserProfileRepository AppUserProfileRepository { get; }

        public IAppUserRepository AppUserRepository { get; }

        public ICategoryRepository CategoryRepository { get; }

        public ICommentRepository CommentRepository { get; }

        public IEventCommentRepository EventCommentRepository { get; }

        public IEventRepository EventRepository { get; }

        public UnitOfWork(MyContext context, 
            IAppUserRepository appUserRepository, 
            IAppUserProfileRepository appUserProfileRepository,
            ICategoryRepository categoryRepository,
            ICommentRepository commentRepository,
            IEventCommentRepository eventCommentRepository,
            IEventRepository eventRepository)
        {
            _context=context;
            AppUserRepository = appUserRepository;
            AppUserProfileRepository= appUserProfileRepository;
            CategoryRepository= categoryRepository;
            CommentRepository= commentRepository;
            EventCommentRepository= eventCommentRepository;
            EventRepository= eventRepository;
        }

        public async ValueTask DisposeAsync()
        {
            await _context.DisposeAsync();
        }

        public async Task<int> SaveAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
