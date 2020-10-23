using TP3.Domain.Entities;
using TP3.Domain.Interfaces;

namespace TP3.Infrastructure.Implementations
{
    public class ChallengeRepository : Repository<Challenge>, IChallengeRepository
    {
        protected Context _context { get; set; }
        public ChallengeRepository(Context context) : base(context)
        {
            _context = context;
        }



    }
}
