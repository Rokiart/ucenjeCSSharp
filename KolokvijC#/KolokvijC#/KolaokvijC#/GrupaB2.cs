using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Runtime.Intrinsics.X86;
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

            ////*********************************************************************************************************************************************************************************

            ////Napišite program koji učitava 5 realnih brojeva u jednodimenzionalno polje, pritom je potrebno koristiti petlju po izboru.
            ////Nakon što su učitani svi elementi polja potrebno je ispisati sve elemente polja te vrijednost najvećeg elementa polja.
            ////Format ispisa mora biti kao u primjeru.
            ////Npr. ako su redom učitani brojevi
            ////5.5,
            ////7.8,
            ////6.2,
            ////4.7
            ////9
            ////potrebno je ispisati: "Elementi polja su: 5.5 7.8 6.2 4.7 9 Vrijednost najvećeg elementa polja iznosi: 9!" 

            //double[] polje = new double[5];                   // u trenutku kad smo odredili matricu u ovom slucaju jednodimenzionalnu te kolicinu podataka koju cemo unijet(5) ,
            //                                                 // ta matrica "polje" ima vec postavljene vrijednosti za svih 5 podataka , koji iznosi 0
            //double najveci = Double.MinValue;                // Metoda MinValue oznacava najmanji moguci broj , kod Metode je dobro ispisivati "Double" , a kod varijabli "double" radi preglednosti

            //int i = 0;
            //for (i = 0; i < polje.Length; i++) 
            //  {
            //    Console.WriteLine("Unesite  " + (i + 1) +  ".  broj :");
            //    double x = Convert.ToDouble(Console.ReadLine());

            //    polje[i] = x;                                //u polje na indeksu i sprmi vrijednost x 

            //      if (x > najveci)
            //    {
            //        najveci = x;
            //    }
            //  }

            //Console.WriteLine("Elementi polja su: ");

            //for ( i = 0; i < polje.Length; i++) 
            //{
            //    Console.WriteLine(polje[i]);
            //}

            //Console.WriteLine("Vrijednost najvećeg elementa polja iznosi: " + najveci + " ! ");


            //*****************************************************************************************************************************************************************************  

            //// Napišite program koji učitava tri realna broja a, b i c. Ako je broj c manji od broja a potrebno je ispisati umnožak učitanih brojeva,
            //// inače ako uvjet ne vrijedi potrebno je ispisati "Nisu uneseni ispravni brojevi!".
            //// Brojevi mogu imati decimalnu točku. Ispis je potrebno formatirati tako da se ispisuju i operandi i operatori.
            //// Broj decimalnih mjesta u ispisu nije bitan. Npr. ako se učitaju redom brojevi a = 2.5, b = 1.5 i c = 2
            //// za umnožak učitanih brojeva potrebno je ispisati "2.5 * 1.5 * 2 = 7.5". 


            //Console.WriteLine("Unesite a :");
            //double a = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("Unesite b :");
            //double b = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("Unesite c :");
            //double c = Convert.ToDouble(Console.ReadLine());

            //double rezultat = 0;

            //if (c>a)
            //{
            //    rezultat = a * b * c;

            //    Console.WriteLine("Rezultat je " + a + " * " + b + " * " + c + " = " + rezultat + " !");
            //}
            //else
            //{
            //    Console.WriteLine("Nisu uneseni ispravni brojevi!");
            //}


            //**************************************************************************************************************************************************************************

            //// Napišite program koji učitava prirodne brojeve u jednodimenzionalno polje s 4 elementa.
            //// Nakon što su učitani svi elementi polja potrebno je ispisati sve elemente polja te njihov zbroj.
            //// Ispis mora biti u sljedećem formatu: npr.ako su redom učitani brojevi 5 6 7 2,
            //// potrebno je ispisati: "Elementi polja su: 5 6 7 2 Zbroj elemenata polja iznosi: 20"

            //int[] polje = new int[4];



            //for (int i = 0; i < polje.Length; i++)
            //{
            //    Console.Write("Unesite " + (i + 1) + ".  broj : ");
            //    polje[i] = Convert.ToInt32(Console.ReadLine());

            //}

            //int zbroj = 0;
            //Console.Write("Elementi polja su:");

            //for (int i = 0; i < polje.Length; i++)
            //{
            //    Console.Write(" "+ polje[i]);
            //    zbroj = zbroj + polje[i];
            //}
            //Console.WriteLine("\nZbroj elemenata polja iznosi:"+ zbroj);                     //  \n escape karakter koji daje naredbu "prebaci u novi red unutar stringa"


















        }
    }
}
