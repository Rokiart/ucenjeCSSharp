

using System.Security.Cryptography;

namespace KolaokvijC_
{
    internal class GrupaD1
    {
        public static void Izvedi()
        {
            //Napišite program koji učitava 9 prirodnih brojeva u dvodimenzionalno polje(matricu 3 x 3), 
            //pritom je potrebno koristiti petlje po izboru.Nakon što su učitani svi elementi matrice potrebno je ispisati samo drugi stupac matrice prema formatu u primjeru.
            //Npr.ako su redom učitani brojevi po redcima
            //1,2,3
            //4,5,6
            //7,8,9
            //potrebno je ispisati: "Elementi drugog stupca matrice su: 2 5 8"


            int[,] matrica = new int[3, 3];                      //postavljanje matrice 3 sa 3 od toga je prvi broj redaka (vodoravno) ,a drugi kolona ili stupac (okomito)
                                                                  // int[,] podatak u zagradi oznacava da ce biti u dve dimenzije , int[,,] bi oznacavao da ce bit trodimenzionalno polje

            for (int i=0; i<matrica.GetLength(0);i++)             // matrica.GetLength(0) nam daje broj redova u matrici , matrica.GetLength(1) nam daje broj stupaca u matrici
                                                                  // 0 i 1 oznacavaju mjesto u zagradi .1. i 2. program broji od nule

            {
                for (int j = 0; j < matrica.GetLength(1); j++)    // nesmije bit isti indeks . Na prvoj petlji je indeks i koji se odnosi na redove,
                                                                  // a na drugoj petlji je indeks j koja se odnosi na stupce
                {
                    Console.WriteLine("Unesite elemente matrice [" + i + " , " + j + " ] : ");
                    matrica[i, j] = Convert.ToInt32(Console.ReadLine());

                    
                }
                Console.WriteLine("Elementi drugog stupca matrice su: ");

            }
            for (int i = 0; i < matrica.GetLength(0); i++)
            {
                Console.WriteLine(matrica[i,1]);
            }
        }
    }
}
