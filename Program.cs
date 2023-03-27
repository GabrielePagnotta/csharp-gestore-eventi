using csharp_gestore_eventi;
//milestone 1
Evento concerto1 = new Evento("jazzMusic",new DateTime(2023,08,27));

//Aggiunta numero di posti prenotati con conseguente salvatasggio del dato:
Console.WriteLine(concerto1.PrenotaPosti(10));
Console.WriteLine(concerto1.NumeroPosti);

//rimozione nuemri di posti prenotati con conseguente salvatasggio del dato:
Console.WriteLine(concerto1.DisdiciPosti(1));
Console.WriteLine(concerto1.NumeroPosti);

//stampa a schermo risultato dell'override di ToString();
Console.WriteLine(concerto1.ToString());