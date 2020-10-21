using TP3.Domain.Entities;
using TP3.Domain.Interfaces;

namespace TP3.Infrastructure.Implementations
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        protected Context _context { get; set; }
        public UserRepository(Context context) : base(context)
        {
            _context = context;
        }



    }
}
