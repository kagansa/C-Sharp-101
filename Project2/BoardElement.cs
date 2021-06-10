namespace Project2
{
    public class BoardElement
    {
        public Card Card { get; set; }
        public StatusType Status { get; set; }

        public BoardElement(Card card, StatusType status)
        {
            this.Card = card;
            this.Status = status;
        }

        public BoardElement()
        {
        }
    }
}