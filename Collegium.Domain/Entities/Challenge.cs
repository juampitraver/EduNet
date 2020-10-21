namespace TP3.Domain.Entities
{
    public class Challenge
    {
        public long Id { get; set; }
        public string Description { get; set; }
        public string Title { get; set; }
        public string Code { get; set; }
        public long UserId { get; set; }
        public User User { get; set; }
    }
}
