

namespace ConsoleApp1
{
    internal class Zadaci4
    {
        //static void Main(string[] args)
        //{
        //    /*
        //        Napišite metodu ZbrojiOduzmi koja preko argumenata prima dva cijela broja a i b te 
        //        vraća rezultat operacije zbrajanja i oduzimanja cijelih brojeva unutar intervala[a, b] (uključujuće granice). 
        //        Za svaki broj unutar intervala[a, b] provjerava se da li je djeljiv ili s 3 ili s 4.Ako je broj djeljiv s 3 onda se broj pribraja rezultatu,
        //        a ako je broj djeljiv s 4 onda se broj oduzima od rezultata. Početna vrijednost rezultata je 0.
        //        Učitavanje dva prirodna broja, poziv metode ZbrojiOduzmi i ispis rezultata potrebno je napraviti unutar Main metode.
        //        Npr.ako korisnik preko tipkovnice unese brojeve a = 2 i b = 7 potrebno je ispisati: "Rezultat operacije ZbrojiOduzmi unutar intervala [2, 7] iznosi: 5!".
        //        Budući da su unutar intervala[2, 7] brojevi djeljivi s tri 3 i 6, a broj djeljiv s četiri je samo 4, rezultat je 0 + 3 - 4 + 6 = 5.
        //    */

        //    Console.Write("Unesite cijeli broj a:");
        //    int a = Convert.ToInt32(Console.ReadLine());

        //    Console.Write("Unesite cijeli broj b:");
        //    int b = Convert.ToInt32(Console.ReadLine());

        //    int rezultat = ZbrojOduzmi (a, b);        // Poslat cemo metodi "ZbrojiOduzmi" varijable a i b 

        //    Console.WriteLine("Rezultat operacije ZbrojiOduzmi unutar intervala ["+a+", "+b+"] iznosi: "+rezultat+"!");


        //}

        //private static int ZbrojOduzmi(int a, int b)      // Metoda "ZbrojOduzmi()" unutar zagrada je ono šta ta metoda prima i u vitičastim će biti šta metoda raditi .
        //                                                  // kad nepise nista ispred static smatra se da je private , te ce bit vidljivo metodi unutar klase
        //                                                  // umjesto "void" (naziv za metodu koja nista nevraca) stavljamo naziv "int" posto ce metoda vracat intidjer (prirodni broj)
        //{
        //    int rezultat = 0;

        //    for ( int i = a; i <= b; i++ )           //Petlja koja krece od a i ide do b . SVe sto se nalazi u petlji mora bit definirano prije petlje 
        //    {
        //        if (i % 3 == 0)                      // Znak % se naziva modulo , to je operator koji daje ostatak cijelbrojnog dijeljenja .
        //                                             // U primjeru pokazuje ako je brojač "i" dijeljiv sa 3 ostatak ce biti 0 . Ako je brojac (petlja) ulazi u računicu 
        //        {
        //            rezultat = rezultat + i;         // ovo se moze i napista pravilnije  ( rezultat += i) , sto znaci rezultat uvecaj za i
                               
        //        }
        //        if ( i % 4 == 0)                     // U ovom slucaju nesmije ici naredba "else if" posto  petlja provjerava dali je broj
        //                                             // dijeljiv i sa 3 i sa 4 te bi na prvom true rezultatu stala i nebi provjeravala dalje
        //        {
        //            rezultat -= i;
        //        }
        //        return rezultat;
        //    }
        //}

    }
}
