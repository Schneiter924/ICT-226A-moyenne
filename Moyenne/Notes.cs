using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moyenne
{
    public class Notes
    {
        public Notes()
        {
            
        }

        public Notes(decimal note)
        {
           
        }

        public decimal NotesDecimale { set; get; }

        public decimal NotesEntier { set; get; }

        public decimal Convertion()
        {
            decimal test = NotesEntier + (NotesDecimale / 10);

            return test;
        }

        public decimal DeConvertionEntier(decimal note)
        {
            int entier = (int)note;
            return entier;
        }
        public decimal DeConvertionDecimale(decimal note)
        {
            int entier = (int)note;
            int decimale = (int)((note * 10) - (10 * entier));
            return decimale;
        }

        public override string ToString()
        {
            string note = "";
            if (NotesDecimale == 0)
            {
                note = NotesEntier + ".0";
            }
            else
            {
                note = NotesEntier + "." + NotesDecimale;
            }

            return note;
        }
    }
}
