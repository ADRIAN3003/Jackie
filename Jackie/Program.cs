using Jackie.SajatOsztaly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Jackie
{
    class Program
    {
        static List<Evstat> evekStat = new List<Evstat>();

        static void Main(string[] args)
        {

            MasodikFeladat();
            HarmadikFeladat();
            NegyedikFeladat();
            OtodikFeladat();
            HatodikFeladat();

            Console.ReadKey();
        }

        private static void HatodikFeladat()
        {
            Console.WriteLine("6. feladat: jackie.html");
            using (StreamWriter sw = new StreamWriter("jackie.html"))
            {
                sw.WriteLine("<!DOCTYPE html><html><head></head>");
                sw.WriteLine("<style>td { border: 1px solid black; }</style>");
                sw.WriteLine("<body><h1>Jackie Stewart</h1><table>");
                foreach (var item in evekStat)
                {
                    sw.WriteLine($"<tr><td>{item.Year}</td><td>{item.Races}</td><td>{item.Wins}</td></tr>");
                }
                sw.WriteLine("</table></body></html>");
            }
        }

        private static void OtodikFeladat()
        {
            Console.WriteLine("5. feladat:");

            //Dictionary<int, int> stat = new Dictionary<int, int>();

            //for (int i = 0; i < evekStat.Count; i++)
            //{
            //    if (stat.ContainsKey(evekStat[i].HanyasEvek))
            //    {
            //        stat[evekStat[i].HanyasEvek] += evekStat[i].Wins;
            //    }
            //    else
            //    {
            //        stat.Add(evekStat[i].HanyasEvek, evekStat[i].Wins);
            //    }
            //}

            //foreach (var item in stat)
            //{
            //    Console.WriteLine($"\t{item.Key}-es évek: {item.Value} megnyert verseny");
            //}

            //var hatvanas = from verseny in evekStat
            //               where verseny.HanyasEvek is 60
            //               group verseny.HanyasEvek by verseny.Wins;

            //Console.WriteLine($"\t60-as évek: {hatvanas.Sum(x => x.Key)} megnyert verseny");

            //var hetvenes = from verseny in evekStat
            //               where verseny.HanyasEvek is 70
            //               group verseny.HanyasEvek by verseny.Wins;

            //Console.WriteLine($"\t70-es évek: {hetvenes.Sum(x => x.Key)} megnyert verseny");


            var egybe = (from verseny in evekStat
                        group verseny by verseny.HanyasEvek).ToList();

            foreach (var item in egybe)
            {
                Console.WriteLine($"\t{item.Key}-es évek: {item.Sum(x => x.Wins)} megnyert verseny");
            }
        }

        private static void NegyedikFeladat()
        {
            //int races = evekStat[0].Races;
            //int o = 0;
            //for (int i = 0; i < evekStat.Count; i++)
            //{
            //    if (evekStat[i].Races > races)
            //    {
            //        races = evekStat[i].Races;
            //        o = i;
            //    }
            //}

            //Console.WriteLine("4. feladat: " + evekStat[o].Year);

            var ev = (from evek in evekStat
                     orderby evek.Races descending
                     select evek.Year).ToList();

            Console.WriteLine("4. feladat: " + ev[0]);
        }

        private static void HarmadikFeladat()
        {
            Console.WriteLine("3. feladat: " + evekStat.Count());
        }

        private static void MasodikFeladat()
        {
            using (StreamReader sr = new StreamReader("jackie.txt"))
            {
                sr.ReadLine();

                while (!sr.EndOfStream)
                {
                    #region Régi megoldás
                    //string[] tomb = sr.ReadLine().Split('\t');

                    //Evstat evstat = new Evstat(
                    //    Convert.ToInt32(tomb[0]), 
                    //    Convert.ToInt32(tomb[1]),
                    //    Convert.ToInt32(tomb[2]),
                    //    Convert.ToInt32(tomb[3]),
                    //    Convert.ToInt32(tomb[4]), 
                    //    Convert.ToInt32(tomb[5])
                    //);
                    //evekStat.Add(evstat); 
                    #endregion

                    evekStat.Add(new Evstat(sr.ReadLine()));
                }
            }
        }
    }
}
