using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_gestore_eventi
{
    public class ProgrammaEventi
    {
        public string Titolo;
        public List<Evento> Eventi;

        public ProgrammaEventi(string titolo)
        {
            Titolo = titolo;
            Eventi = new List<Evento>();
        }


        public void AggiungiEvento(Evento evento)
        {
            Eventi.Add(evento);
        }
        public List<Evento> AddDates(DateTime data)
        {
            return Eventi.Where(e => e.Data.Date == data.Date).ToList();
        }
        public static string Print(List<Evento> eventi)
        {
            
            foreach (var evento in eventi)
            {  
                Console.WriteLine("------------------------------------");
                Console.WriteLine($"{evento.Data:dd/MM/yyyy}");
                Console.WriteLine($"{evento.Titolo}");
            }
            return eventi.ToString();
        }
        public int NumeroEventi()
        {
            return Eventi.Count;
        }

        public void SvuotaEventi()
        {
            Eventi.Clear();
        }

    }
}
