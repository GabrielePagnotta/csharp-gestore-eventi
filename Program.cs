using csharp_gestore_eventi;
//Milestone 1:

Evento concerto1 = new Evento("jazzMusic",new DateTime(2023,08,27));

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

Console.WriteLine("vuoi creare un nuovo evento? Y/N");
string InputStart = Console.ReadLine();

    Evento concerto = new Evento();
if(InputStart == "Y" | InputStart == "y")
{
    
    Console.WriteLine("inserisci il titolo dell'evento");
    string InputTitle = Console.ReadLine();
    concerto.Titolo = InputTitle;
    Console.WriteLine("inserisci la data dell'evento dd/MM/yy");
    var InputDate =Convert.ToDateTime( Console.ReadLine());
    concerto.Data = InputDate;

}
else if(InputStart == "N" | InputStart == "n")
{
    Environment.Exit(0);

}
Console.WriteLine(concerto.Titolo);
Console.WriteLine(concerto.Data);




