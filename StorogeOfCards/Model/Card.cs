namespace StorogeOfCards.Model
{
    public class Card
    {
        public int Id { get; set; }
        public string CardName { get; set; } = string.Empty;//Названеи карты
        public string Suit { get; set; } = string.Empty;//Масть карты
        public string UrlImage { get; set; } = string.Empty;//ссылка на картинку 
        public Card() { }
    }
}
