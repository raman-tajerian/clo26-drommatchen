namespace Drommatchen
{
    public class Spelare
    {

        // Privata fält
        private string _namn;
        private int _nummer;
        private string _position;

        private int _mal;

        // Properties — publik get, privat set
        public string Namn
        {
            get { return _namn; }
            private set { _namn = value; }
        }

        public int Nummer
        {
            get { return _nummer; }
            private set { _nummer = value; }
        }
        public string Position
        {
            get { return _position; }
            private set { _position = value; }
        }
        public int Mal
        {
            get { return _mal; }
            private set { _mal = value; }
        }
    }
}

/*
    public int Nummer
    {
        // Skapa get och privat set för Nummer
    }

    public string Position
    {
        // Skapa get och privat set för Position
    }

    // Konstruktor
    public Spelare(string namn, int nummer, string position)
    {
        // TODO: tilldela de privata fälten
    }
}

*/
