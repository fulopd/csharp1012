using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Korcsolya
{
    class Program
    {
        static List<Gyakorlatsor> rovidProgList = new List<Gyakorlatsor>();
        static List<Gyakorlatsor> dontoList = new List<Gyakorlatsor>();

        static void Main(string[] args)
        {
            #region 1. feladat
            FileStream fs = new FileStream("rovidprogram.csv", FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            sr.ReadLine(); //fejléc beolvasása

            while (!sr.EndOfStream)
            {
                string sor = sr.ReadLine();
                string[] adat = sor.Split(';');

                Gyakorlatsor elem = new Gyakorlatsor(
                    adat[0],
                    adat[1],
                    Convert.ToDouble(adat[2].Replace('.', ',')),
                    Convert.ToDouble(adat[3].Replace('.', ',')),
                    Convert.ToInt32(adat[4]));
                rovidProgList.Add(elem);
            }
            sr.Close();
            fs.Close();


            fs = new FileStream("donto.csv", FileMode.Open);
            sr = new StreamReader(fs);
            sr.ReadLine(); //fejléc beolvasása

            while (!sr.EndOfStream)
            {
                string sor = sr.ReadLine();
                string[] adat = sor.Split(';');

                Gyakorlatsor elem = new Gyakorlatsor(
                    adat[0],
                    adat[1],
                    Convert.ToDouble(adat[2].Replace('.', ',')),
                    Convert.ToDouble(adat[3].Replace('.', ',')),
                    Convert.ToInt32(adat[4]));
                dontoList.Add(elem);
            }
            sr.Close();
            fs.Close();

            #endregion


            #region 2. feladat
            Console.WriteLine("2. feladat:");
            Console.WriteLine("\t A rövid programban: " + rovidProgList.Count + " induló volt.");
            #endregion


            #region 3. feladat
            Console.WriteLine("3. feladat:");

            bool magyarVanE = false;
            int counter = 0;

            while (!magyarVanE && counter < dontoList.Count)
            {
                if (dontoList[counter].Orszag.Equals("HUN")) magyarVanE = true;
                counter++;
            }

            Console.WriteLine(magyarVanE?"\tVan magya versenyző a döntőben.": "\tNincs magya versenyző a döntőben.");

            #endregion

            

            Console.ReadKey();
        }

        #region 4. feladat
        static double OsszePontszam(string nev) {

            double osszpont = 0;

            foreach (var item in rovidProgList)
            {
                if (item.Nev == nev)
                {
                    osszpont += item.techPont + item.kompPont - item.hibaPont;
                }
            }
                        

            foreach (var item in dontoList)
            {
                if (item.Nev == nev)
                {
                    osszpont += item.techPont + item.kompPont - item.hibaPont;
                }
            }

            //Gyakorlatsor gys = rovidProgList.SingleOrDefault(x => x.Nev.Equals(nev));
            //osszpont += gys.techPont + gys.kompPont - gys.hibaPont;
            //Gyakorlatsor gys2 = dontoList.SingleOrDefault(x => x.Nev.Equals(nev));
            //osszpont += gys2.techPont + gys2.kompPont - gys2.hibaPont;


            return osszpont;
        }


        #endregion
    }
}
