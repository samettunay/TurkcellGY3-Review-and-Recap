using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    public class Ekmek
    {
        public int Adet { get; set; }
        public string Tur { get; set; }

        public Ekmek() : this(1, "Somun")
        {
        }

        public Ekmek(string tur) : this(1, tur)
        {

        }

        public Ekmek(int adet) : this(adet, "Somun")
        {

        }

        public Ekmek(int adet, string tur)
        {
            Adet = adet;
            Tur = tur;
        }
    }
}
