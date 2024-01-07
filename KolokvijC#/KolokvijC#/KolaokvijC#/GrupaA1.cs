using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace KolaokvijC_
{
    internal class GrupaA1
    {
        public static void Izvedi()
        {
            //*******************************************************************************************************************************************************************

            //Napišite program koji učitava četiri realne vrijednosti s tipkovnice, redom x1, y1, x2 i y2 koje predstavljaju dvije točke u koordinatnom sustavu T1(x1, y1) i T2(x2, y2),
            //odnosno dužinu 𝑇1𝑇2 ̅̅̅̅̅̅. Ako su sve unesene vrijednosti unutar intervala[-10, 10]
            //potrebno je izračunati i ispisati točku polovišta dužine u formatu ispisa kao u primjeru,
            //inače je potrebno ispisati „Nisu unesene ispravne vrijednosti!“.
            //Provjeru da li je pojedina vrijednost unutar intervala[-10, 10] potrebno je napisati u zasebnoj metodi Provjera koja prima samo jedan argument te vraća rezultat provjere.
            //Polovište se određuje kao P(x, y) = P((x1 + x2) / 2, (y1 + y2) / 2).
            //Primjerice ako se redom učitaju vrijednosti - 1.5, 3.0, 4.0, -2.0 potrebno je ispisati: „Polovište učitane dužine je: P(1.25, 0.5)“. 


            Console.WriteLine("Unesite koordinatu x1 točke T1 : ");
            double x1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Unesite koordinatu y1 točke T1 : ");
            double y1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Unesite koordinatu x2 točke T2 : ");
            double x2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Unesite koordinatu y2 točke T2 : ");
            double y2 = Convert.ToDouble(Console.ReadLine());

           


            if (Provjera(x1) && Provjera(y1) && Provjera(x2) && Provjera(y2))

            {
                double xp = (x1 + x2) / 2;
                double yp = (y1 + y2) / 2;

                Console.WriteLine("Polovište učitane dužine je: P(" + xp + " , " + yp + ")");
            }
            else
            {
                Console.WriteLine("Nisu unesene ispravne vrijednosti!");
            }



        }

        static bool Provjera(double broj)                          // Metoda "Provjera" prima uunutar zagrade vrijednost u lokalnu varijablu "broj" koju joj pošalje program (x1,x2,y1,y2)
        {
            if (broj >= -10 && broj <= 10) ;
            {
                return true;
            }
           
                return false;
        


        }                                                    


    }
}
