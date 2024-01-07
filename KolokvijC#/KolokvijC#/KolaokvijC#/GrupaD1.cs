

using System.Security.Cryptography;

namespace KolaokvijC_
{
    internal class GrupaD1
    {
        public static void Izvedi()
        {

            //********************************************************************************************************************************************************************************

            ////Napišite program koji učitava 9 prirodnih brojeva u dvodimenzionalno polje(matricu 3 x 3), 
            ////pritom je potrebno koristiti petlje po izboru.Nakon što su učitani svi elementi matrice potrebno je ispisati samo drugi stupac matrice prema formatu u primjeru.
            ////Npr.ako su redom učitani brojevi po redcima
            ////1,2,3
            ////4,5,6
            ////7,8,9
            ////potrebno je ispisati: "Elementi drugog stupca matrice su: 2 5 8"


            //int[,] matrica = new int[3, 3];                      //postavljanje matrice 3 sa 3 od toga je prvi broj redaka (vodoravno) ,a drugi kolona ili stupac (okomito)
            //                                                      // int[,] podatak u zagradi oznacava da ce biti u dve dimenzije , int[,,] bi oznacavao da ce bit trodimenzionalno polje

            //for (int i=0; i<matrica.GetLength(0);i++)             // matrica.GetLength(0) nam daje broj redova u matrici , matrica.GetLength(1) nam daje broj stupaca u matrici
            //                                                      // 0 i 1 oznacavaju mjesto u zagradi .1. i 2. program broji od nule

            //{
            //    for (int j = 0; j < matrica.GetLength(1); j++)    // nesmije bit isti indeks . Na prvoj petlji je indeks i koji se odnosi na redove,
            //                                                      // a na drugoj petlji je indeks j koja se odnosi na stupce
            //    {
            //        Console.WriteLine("Unesite elemente matrice [" + i + " , " + j + " ] : ");
            //        matrica[i, j] = Convert.ToInt32(Console.ReadLine());


            //    }
            //    Console.WriteLine("Elementi drugog stupca matrice su: ");

            //}
            //for (int i = 0; i < matrica.GetLength(0); i++)
            //{
            //    Console.WriteLine(matrica[i,1]);
            //}


            //***************************************************************************************************************************************************************************


            // Napišite metodu Izracun koja preko argumenta prima tri prirodna broja a, b i c,
            // te ispisuje rezultat matematičkog izraza: 𝑐8+∑𝑖 𝑏 𝑖=𝑎 Granice a i b su uključujuće.
            // Učitavanje tri prirodna broja i poziv metode Izracun potrebno je napraviti unutar Main metode.
            // Npr. ako korisnik preko tipkovnice unese brojeve a = 2, b = 5 i c = 1
            // potrebno je ispisati: "Rezultat zadanog matematičkog izraza iznosi: 15!", budući da je: 𝑐8=18=1 ∑2+3+4+5=14 𝑏 𝑖=𝑎 

            Console.WriteLine("Unesite a :");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Unesite b :");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Unesite c :");
            int c = Convert.ToInt32(Console.ReadLine());

            Izracun(a, b, c);                                         // Pozivanje metode pod imenom "Izracun" , pripazit na velika i mala slova





        }

        static void Izracun(int a , int b , int c )
        {
            double rezultat = 0;

            for (int i = a; i < b; i++)
            {
                rezultat += i;
            }
            rezultat += Math.Pow(c, 8);

            Console.WriteLine(" rezultat je : " + rezultat);
        }


    }
}
