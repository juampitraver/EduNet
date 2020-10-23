namespace TP3.Domain.Entities
{
    public class ChallengeCable : IsActivable
    {
        public ChallengeCable()
        {
            IsActive = true;
        }
        public long Id { get; set; }
        public long ChallengeId { get; set; }
        public eCableColor CableColor { get; set; }
        public int Order { get; set; }
        public bool IsActive { get; set; }
        public Challenge Challenge { get; set; }
    }
}
