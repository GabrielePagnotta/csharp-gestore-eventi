using csharp_gestore_eventi;
//Milestone 1:

Evento concerto1 = new Evento("jazzMusic", new DateTime(2023, 08, 27));

//Aggiunta numero di posti prenotati con conseguente salvatasggio del dato:
Console.WriteLine(concerto1.PrenotaPosti(10));
Console.WriteLine(concerto1.NumeroPosti);

//rimozione nuemri di posti prenotati con conseguente salvatasggio del dato:
Console.WriteLine(concerto1.DisdiciPosti(1));
Console.WriteLine(concerto1.NumeroPosti);

//stampa a schermo risultato dell'override di ToString();
Console.WriteLine(concerto1.ToString());

//----------------------------------------------------------------------------------

//Milestone 2:

Evento concerto = new Evento();

Console.WriteLine("inserisci il titolo dell'evento");
string InputTitle = Console.ReadLine();
concerto.Titolo = InputTitle;

Console.WriteLine("inserisci la data dell'evento dd/MM/yy");
var InputDate = Convert.ToDateTime(Console.ReadLine());
concerto.Data = InputDate;

Console.WriteLine("inserisci il numero di posti disponibili");
int inputCapacity = Convert.ToInt32(Console.ReadLine());
concerto.Capienza = inputCapacity;

Console.WriteLine("quante prenotazioni vuoi effettuare?");
int loopnum = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < loopnum; i++)
{
    Console.WriteLine("inserisci quanti posti vuoi prenotare");
    int InputReservation = Convert.ToInt32(Console.ReadLine());
    var resultreservation = concerto.PrenotaPosti(InputReservation);
    int capienza = concerto.Capienza -= resultreservation;

    Console.WriteLine($"hai prenotato {resultreservation} posti");
    Console.WriteLine($"posti rimanenti {capienza}");
}
Console.WriteLine("vuoi disdire dei posti Y/N");
string InputDisdetta = Console.ReadLine();
if (InputDisdetta == "Y"| InputDisdetta == "y")
{
    Console.WriteLine("quanti posti vuoi disdire");
    int Inputboh=Convert.ToInt32( Console.ReadLine());
    Console.WriteLine($"posti disdetti, capacità attuale {Inputboh + concerto.Capienza}");
}
else if (InputDisdetta == "N" | InputDisdetta == "n")
{
    Environment.Exit(0);
}








