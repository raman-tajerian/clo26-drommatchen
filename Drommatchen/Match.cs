namespace Drommatchen
{
    public class Match
    {
        public string Hemmalag { get; private set; }
        public string Bortalag { get; private set; }
        public string Datum { get; private set; }


        // Konstruktor: skapar en match med hemmalag, bortalag och datum
        public Match(string hemmalag, string bortalag, string datum)
        {
            Hemmalag = hemmalag;
            Bortalag = bortalag;
            Datum = datum;
        }

        // Metod 1: skriv ut matchens lag och datum
        public void Presentera()
        {
            Console.WriteLine($"Matchens lag: {Hemmalag} och {Bortalag}");
            Console.WriteLine($"Datum: {Datum}");
        }

        // Metod 2: skriv ut spelarens namn, nummer och position
        public void AnnounceraMålskytt(Spelare spelare)
        {
            Console.WriteLine($"Namn: {spelare.Namn} Nummer: {spelare.Nummer} Position: {spelare.Position}");
        }
        // Metod 3: skriv ut matchhjälte om en spelare gjort minst ett mål
        public bool ÄrMatchhjälte(Spelare spelare)
        {
            return spelare.Mal > 0;
        }
    }

}
