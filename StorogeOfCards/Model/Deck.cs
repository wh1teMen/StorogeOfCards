namespace StorogeOfCards.Model
{
    public class Deck
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;//Название колоды
        public int NumberOfCards { get; set; }//Количесвто карт
        public string Status { get; set; } = string.Empty;//Статус колоды (состояние колоды json)
        public Deck() { }

    }
   
}
