namespace Project2
{
    public class Card
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public int AssignedMemberId { get; set; }
        public SizeType Size { get; set; }

        public Card(string title, string content, int assignedMemberId, SizeType size)
        {
            this.Title = title;
            this.Content = content;
            this.AssignedMemberId = assignedMemberId;
            this.Size = size;
        }

        public Card()
        {
        }
    }
}