using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace KolaokvijC_
{
    internal class GrupaB2
    {
        public static void Izvedi()
        {
            //Napišite program koji učitava 5 realnih brojeva u jednodimenzionalno polje, pritom je potrebno koristiti petlju po izboru.
            //Nakon što su učitani svi elementi polja potrebno je ispisati sve elemente polja te vrijednost najvećeg elementa polja.
            //Format ispisa mora biti kao u primjeru.
            //Npr. ako su redom učitani brojevi
            //5.5,
            //7.8,
            //6.2,
            //4.7
            //9
            //potrebno je ispisati: "Elementi polja su: 5.5 7.8 6.2 4.7 9 Vrijednost najvećeg elementa polja iznosi: 9!" 

            double[] polje = new double[5];                   // u trenutku kad smo odredili matricu u ovom slucaju jednodimenzionalnu te kolicinu podataka koju cemo unijet(5) ,
                                                             // ta matrica "polje" ima vec postavljene vrijednosti za svih 5 podataka , koji iznosi 0
            double najveci = Double.MinValue;                // Metoda MinValue oznacava najmanji moguci broj , kod Metode je dobro ispisivati "Double" , a kod varijabli "double" radi preglednosti

            int i = 0;
            for (i = 0; i < polje.Length; i++) 
              {
                Console.WriteLine("Unesite  " + (i + 1) +  ".  broj :");
                double x = Convert.ToDouble(Console.ReadLine());

                polje[i] = x;                                //u polje na indeksu i sprmi vrijednost x 

                  if (x > najveci)
                {
                    najveci = x;
                }
              }
             
            Console.WriteLine("Elementi polja su: ");

            for ( i = 0; i < polje.Length; i++) 
            {
                Console.WriteLine(polje[i]);
            }

            Console.WriteLine("Vrijednost najvećeg elementa polja iznosi: " + najveci + " ! ");


        }
    }
}
