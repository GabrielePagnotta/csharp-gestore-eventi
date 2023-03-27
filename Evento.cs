using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace csharp_gestore_eventi
{
    public class Evento
    {
        int capienza;
        int numeroPosti;
        public  string Titolo { get; set; }
        public  DateTime  Data { get; set; }

      
        public int Capienza
        {
            get
            {
                return capienza;
            }
             set { 
                capienza = value;
            }
        }

        public int NumeroPosti
        {
            get
            {
                return numeroPosti;
            }
            private set
            {
                numeroPosti = value;
            }
             
            
        }


        //costruttore

        public Evento(string titolo,DateTime data) {
            Titolo = titolo;
            Data = data;
            Capienza = 100;
        }

        public Evento()
        {
            
        }


        //metodi:

        public int PrenotaPosti(int posti)
        {
            
            this.NumeroPosti = posti;

            if (this.Capienza <= this.NumeroPosti)
            {
                throw new Exception("non ci sono posti disponibili");
            }else if(this.Data < DateTime.Now)
            {
                throw new Exception("il concerto non è più disponibile");
            }
            return posti;
        }

        public int DisdiciPosti(int posti)
        {

            int Decremento = this.NumeroPosti - posti;
            
            if ( this.NumeroPosti == 0)
            {
                throw new Exception("non ci sono posti da disdire");
            }
            else if (this.Data < DateTime.Now)
            {
                throw new Exception("il concerto non è più disponibile");
            }
            return this.numeroPosti = Decremento; ;
        }

        public override string ToString()
        {
            var dataformattata = Data.ToString("dd/MM/yy");
            return $"Data:{dataformattata}, Titolo: {Titolo}";
        }

    }
}
