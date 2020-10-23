namespace TP3.Domain.Entities
{
    public class ChallengeElement : IsActivable
    {
        public ChallengeElement()
        {
            IsActive = true;
        }
        public long Id { get; set; }
        public long ChallengeId { get; set; }
        public eElement Element { get; set; }
        public int Quantity { get; set; }
        public bool IsActive { get; set; }
        public Challenge Challenge { get; set; }

    }
}
