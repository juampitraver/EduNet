namespace TP3.Domain.Entities
{
    public class ChallengeCommand
    {
        public long Id { get; set; }
        public long ChallengeId { get; set; }
        public eCommand Command { get; set; }
        public Challenge Challenge { get; set; }
    }
}
