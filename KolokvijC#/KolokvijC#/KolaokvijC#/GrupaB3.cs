using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace KolaokvijC_
{
    internal class GrupaB3
    {
        public static void Izvedi()
        {
            // Napišite program koji učitava imena 5 studenata s tipkovnice u jednodimenzionalno polje koristeći petlju po vlastitom izboru.
            // Nakon što su učitana sva imena studenata potrebno je ispisati sva unesena imena, te ime koje je najduže(ima najviše slova) i najkraće(ima najmanje slova).
            // Format ispisa treba biti kao u primjeru.
            // Primjerice ako se redom učitaju imena: Marko, Ana, Luka, Tomislav i Ante
            // potrebno je ispisati: „Unesena imena studenata su: Marko Ana Luka Tomislav Ante

            // Najduže ime je: Tomislav
            // Najkraće ime je: Ana“.

            //********************************************************************************************
            // vjezba

            //string ime = "Edunova";

            //int BrojSlovan=0                                      // Tražimo koliko ima slobva "n" u stringu "ime"

            //for (int i = 0; i < ime.Length; i++)                  //Funkcija " Lenght " prebrojava koliko karaktera ima u stringu "ime"
            //{
            //    Console.WriteLine(ime[i]);                        // Ispisi mi iz imena ono sto se nalazi na trenutnom indeksu "i" . To je kao da se radi sa jednodimenzionalnim poljima.

            //}

            //********************************************************************************************
            //vjezba

            //string ime = "Edunovan";

            //int BrojSlovan = 0;                                  // Tražimo koliko ima slobva "n" u stringu "ime"

            //for (int i = 0; i < ime.Length; i++)                  //Funkcija " Lenght " prebrojava koliko karaktera ima u stringu "ime"
            //{
            //    if (ime[i] == 'n')                               // u if naredbi trazimo dali je jednako  u stringu "ime" koliko ima char(karakter) koji se stavlja u navodnike s jednom crticom ''
            //    {
            //        BrojSlovan++;                                 // Pokrecemo petlju 
            //    }
            //    Console.Write(BrojSlovan);

            //}

            //*********************************************************************************************
            //zadatak

            string[] studenti = new string[5];                      // definiranje polja "studenti"  = koje u sebi sadrzava novo polje sa indeksom 5 ( kolicina podataka koja ce se unosit)

            for ( int i = 0; i < studenti.Length; i++ )
            {
                Console.Write("Unesite ime " + ( i + 1 ) + "studenta : ");
                studenti[i] = Console.ReadLine();
            }

            string najduzeIme = studenti[0];                                 //prije petlje se mora definirat varijabla sa kojom se radi .Posto radimo s stringovima  ostavicemo prazne navodnike string najduzeIme = "";

            string najkraceIme = studenti[0];                                // Ali posto imamo vec zadana imean studenata iskoristicemo to


            Console.WriteLine("Unesena imena studenata su: ");
            for (int i = 0; i < studenti.Length; i++)
            {
                Console.WriteLine(studenti[i]);

                if (studenti[i].Length > najduzeIme.Length)
                {
                    najduzeIme = studenti[i];
                }
                else if (studenti[i].Length < najkraceIme.Length)
                {
                    najkraceIme = studenti[i];
                }
            }

            Console.WriteLine("\n\tNajduze ime je : " + najduzeIme);                //Ubacena je izlazna sekvenca . \n je sekvenca koja daje naredbu da se prije ispisivanja ide u novi red

            Console.WriteLine("\tNajkrace ime je : " + najkraceIme);                // Jos se nazivaju escape karakteri . \t (kosa crta tab) pomice liniju ispisa 



        }
    }
}
