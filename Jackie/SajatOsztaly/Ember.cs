using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jackie.SajatOsztaly
{
    class Ember
    {
        private string nev;
        private int eletkor;

        public string Nev {
            get { return nev; }
            private set { nev = value; }
        }

        public int Eletkor {
            get { return eletkor; }
            private set { eletkor = value; }
        }

        public Ember(string nev)
        {
            this.nev = nev;
            eletkor = 1;
        }

        public Ember(string nev, int eletkor)
        {
            this.nev = nev;
            if (eletkor < 1 || eletkor > 120)
            {
                this.eletkor = 1;
            }
            else
            {
                this.eletkor = eletkor;
            }
        }

        /*public string GetNev()
        {
            return nev;
        }

        public int GetEletkor()
        {
            return eletkor;
        }*/

        public void Oregszik()
        {
            eletkor++;
        }

        public override string ToString()
        {
            return $"{nev} vagyok. {eletkor} éves.";
        }
    }
}
