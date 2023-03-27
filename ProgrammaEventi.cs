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

        public ProgrammaEventi(string titolo, List<Evento> eventi)
        {
            Titolo = titolo;
            Eventi = new List<Evento>();
        }


        public void AggiungiEvento(Evento evento)
        {
            Eventi.Add(evento);
        }
        public List<Evento> addDates(DateTime data)
        {
            return Eventi.Where(e => e.Data.Date == data.Date).ToList();
        }
        public static string StampaListaEventi(List<Evento> eventi)
        {
            StringBuilder bld = new StringBuilder();
            foreach (var evento in eventi)
            {
                bld.AppendLine($"{evento.Data:dd/MM/yyyy}, {evento.Titolo}");
            }
            return bld.ToString();
        }
        public int NumeroEventi()
        {
            return Eventi.Count;
        }

        public void SvuotaEventi()
        {
            Eventi.Clear();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nome programma evento: {Titolo}");
            foreach (var evento in Eventi)
            {
                sb.AppendLine($"{evento.Data:dd/MM/yyyy} - {evento.Titolo}");
            }
            return sb.ToString();
        }
    }
}
