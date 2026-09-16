public class Match
{
    public string Hemmalag { get; private set; }
    public string Bortalag { get; private set; }
    public string Datum { get; private set; }
    
    // Pluspoäng om ni kommer på hur man kan minska ner koden med properties :)

    // Konstruktor
    public Match(string hemmalag, string bortalag, string datum)
    {
        Hemmalag = hemmalag;
        Bortalag = bortalag;
        Datum = datum;
    }

    // Metod 1: skriv ut matchens lag och datum
    public void Presentera()
    {
        // TODO
    }

    // Metod 2: skriv ut spelarens namn, nummer och position
    public void AnnounceraMålskytt(Spelare spelare)
    {
        // TODO
    }
}
