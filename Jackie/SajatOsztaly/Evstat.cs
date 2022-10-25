using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jackie.SajatOsztaly
{
    class Evstat
    {
        private int year;

        public int Year
        {
            get { return year; }
            private set { year = value; }
        }

        private int races;

        public int Races
        {
            get { return races; }
            private set { races = value; }
        }

        private int wins;

        public int Wins
        {
            get { return wins; }
            private set { wins = value; }
        }

        private int podiums;

        public int Podiums
        {
            get { return podiums; }
            private set { podiums = value; }
        }

        private int poles;

        public int Poles
        {
            get { return poles; }
            private set { poles = value; }
        }

        private int fastests;

        public int Fastests
        {
            get { return fastests; }
            private set { fastests = value; }
        }

        public int HanyasEvek
        {
            get
            {
                //string szovegEv = year.ToString();
                //string harmadik = szovegEv[2].ToString();

                //return Convert.ToInt32(harmadik) * 10;

                return ((year % 100) / 10) * 10;
            }
        }

        public Evstat(int year, int races, int wins, int podiums, int poles, int fastests)
        {
            Year = year;
            Races = races;
            Wins = wins;
            Podiums = podiums;
            Poles = poles;
            Fastests = fastests;
        }

        public Evstat(string adatok)
        {
            Ertekadas(adatok, out year, out races, out wins, out podiums, out poles, out fastests);
        }

        private void Ertekadas(string adatok, out int year, out int races, out int wins, out int podiums, out int poles, out int fastests)
        {
            string[] a = adatok.Split('\t');
            year = Convert.ToInt32(a[0]);
            races = Convert.ToInt32(a[1]);
            wins = Convert.ToInt32(a[2]);
            podiums = Convert.ToInt32(a[3]);
            poles = Convert.ToInt32(a[4]);
            fastests = Convert.ToInt32(a[5]);
        }
    }
}
