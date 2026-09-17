namespace Drommatchen
{
    public class Spelare
    {

        // Auto-properties med publik get och privat set
        public string Namn { get; private set; }
        public int Nummer { get; private set;  }
        public string Position { get; private set; }
        public int Mal { get; private set; }
        

        // Konstruktorer
        public Spelare(string namn, int nummer, string position, int mal)
        {
            Namn = namn;
            Nummer = nummer;
            Position = position;
            Mal = mal;
        }

    }
}
