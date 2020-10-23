using System.Collections.Generic;

namespace TP3.Domain.Entities
{
    public class Challenge : IsActivable
    {
        public Challenge()
        {
            IsActive = true;
        }
        public long Id { get; set; }
        public string Description { get; set; }
        public string Title { get; set; }
        public string Code { get; set; }
        public long UserId { get; set; }
        public eConectionType ConectionType { get; set; }
        public eNetType NetType { get; set; }
        public bool IsActive { get; set; }
        public User User { get; set; }
        public IList<ChallengeElement> Elements { get; set; }
        public IList<ChallengeCable> Cables { get; set; }
    }
}
