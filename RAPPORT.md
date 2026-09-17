Rapport

```
Kurs: Grundläggande OOP i C#
Uppgift: Drömmatchen
Grupp: Team Faun (Raman Tajerian och Martin Bäcklund)
Datum: 2026-09-17
GitHub: raman-tajerian och Martin-Backlund / Länk till repo: https://github.com/raman-tajerian/clo26-drommatchen/tree/main/Drommatchen
```


Klasserna
Vi delade upp arbetet i olika kodfiler för att fördela arbetet jämnt och undvika konflikter. Så en i Spelare.cs och andra i Match.cs och tillsammans i Program.cs. I kodfilen för Spelare skapade vi properties för namn, nummer och positioner och i Match properties för hemmalag, bortalag och datum. För det använde vi “auto-properties” med publika get och privata set så att värdena kan läsas utifrån men bara sättas via konstruktorn. Vi diskuterade mellan gamla och nya metoden av att skriva properties och beslutade för att auto properties blev bäst. Det gav kortare och lättläst kod och tog inte heller ifrån funktionaliteten hos just detta programmet på något sätt. Klasserna har en konstruktor som tar emot och sätter alla värden.

Metoderna

Presentera() raden kommer att skriva ut matchens lag och datum på två rader i konsolen. När det kommer till AnnounceraMålskytt gör den som så att den tar emot ett Spelare-objekt som parameter och då skriver dess namn, position och nummer.

Main()

I Program.cs, alltså våran main skapar vi både ett match-objekt och två spelare-objekt. Här anropar vi Presentera() som då kommer att presentera hemmalag, bortalag och datum. AnnounceraMålskytt för båda spelarna visar också på att metoderna funkar korrekt. 

Git
Eftersom vi jobbade i grupp fick vi verkligen jobba på våra git skills vilket var givande. Vi jobbade i samma repo där Raman bjöd in Martin som collaborator. Som skriver tidigare delades arbetet upp på filnivå. Att kunna jobba i Visual Studio med Git funkade effektivt och att köra Git Pull varje gång för att synka funkade utan problem. Vi stötte på en merge-konflikt en gång vilket var konstigt då vi hade delat upp det i olika filer, men det var mer givande än problem då vi fick lösa en sådan konflikt tillsammans i VS code. 



Kodkvalitet

Vi har använt enligt oss beskrivande namn på klasser, metoder och variabler som “AnnounceraMålskytt” och bestämt oss för att använda kommentarer i de olika blocken eftersom vi jobbar i grupp så får vi logiken förklarade för varandra och för läsaren. Det underlättar även om vi vill gå tillbaka till uppgiften och sätter en sorts rutin att kommentera ofta, lite som att committa sin kod ofta.

VG - Motivering

Vi lade till fältet antal mål (Mal) i Spelare- klassen och ändrade så att konstruktorn tog emot fyra parametrar. I Match-klassen lades det till metoden ÄrMatchhjälte som returnerar true om spelare gjort minst ett mål och om inte visar den false istället.

Varför vi löste det såhär

Anledningen till att vi valde för ÄrMatchhjälte att returnera en bool istället ett resultat direkt i metoden är att det kommer då separera logiken från presentationen. En metod som returnerar ett värde kan användas på fler sätt, den kan skrivas ut, sparas, använda villkor och skicka vidare till annan del i ditt program. Console.WriteLine kan däremot bara göra en sak och därför blir vårt sätt istället det självklara enligt oss på grund av dess flexibilitet och möjligheter till att bygga vidare med.

Git-logg

```
$ git log --oneline
976df4b (HEAD -> main, origin/main, origin/HEAD) Lagt till using system i Match cs
90181a3 löste konflikter, lade till metod 3 samt relevanta kommentarer
cbf4c70 löste konflikt, la till metod 3 i match.cs, lade till relevanta kommentarer
2b170b2 Presenterar matchen med målskyttar och matchhjälten
1e7b401 Skapar matchen, spelare, namn, nummer, position och mål i program cs
7fd4008 lade till metod, skriv ut matchhjälte. samt la till relevanta kommentarer
7e90805 Merge branch 'main' of https://github.com/raman-tajerian/clo26-drommatchen
30bc2aa Ändrat spelare cs till auto-properties
7dfb463 lade till metod 2, skriv ut namn, nummer, position
cee9fa3 Lagt till konstruktorer i spelare
c898b9a Merge branch 'main' of https://github.com/raman-tajerian/clo26-drommatchen
9b9d6df Lade till fält och properties i Spelare
7c4ec7d fixade metod, skriv ut namn, nummer, position
7f6fed0 fixade metod, skriv ut namn, nummer, position
265683b Merge branch 'main' of https://github.com/raman-tajerian/clo26-drommatchen
71bc9a4 Test
941251f la till properties och konstruktor i Match.cs
35825ed Solutionfile added at root
34de7d5 refactor: gör property-kroppar tomma — studerande implementerar själva
66f4917 init: starterrepo för Drömmatchen (Inlämning 1)
```



