using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Korcsolya
{
    class Gyakorlatsor
    {
        //prop + tab tab
        public string Nev { get; set; }
        public string Orszag { get; set; }
        public double techPont { get; set; }
        public double kompPont { get; set; }
        public int hibaPont { get; set; }

        public Gyakorlatsor(string nev, string orszag, double techPont, double kompPont, int hibaPont)
        {
            Nev = nev;
            Orszag = orszag;
            this.techPont = techPont;
            this.kompPont = kompPont;
            this.hibaPont = hibaPont;
        }

        
        

        
        
    }
}
