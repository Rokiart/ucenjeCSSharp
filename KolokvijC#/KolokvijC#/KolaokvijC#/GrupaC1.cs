﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolaokvijC_
{
    internal class GrupaC1
    {
        public static void Izvedi()
        {
            //        Napišite program koji omogućuje korisniku unos lozinke sve dok ona ne bude jednaka vrijednosti lozinke pohranjena u varijabli
            //        lozinka, npr. "a1b2".Lozinka može biti bilo koja riječ ili broj ili kombinacija navedenog. 
            //        U trenutku kada korisnik upiše ispravnu lozinku treba mu se ispisati poruka: "Lozinka je ispravna!".
            //        Za svaku neispravno unesenu lozinku npr. 568 program ispisuje "Unesena lozinka 568 nije ispravna!".

            string lozinka = "a1b2";
            string unos = "";                               //nova varijabla "unos" koja ima vrijednost praznog stringa . Moraju se postavit sve vrijednosti prije petlje 

            do
            {
                Console.Write("Unesite lozinku : ");
                Console.ReadLine();
                if (unos==lozinka)
                {
                    Console.WriteLine("Lozinka je ispravna !");
                }
                else
                {
                    Console.WriteLine("Unesena lozinka " + unos + " nije ispravna . Pokusajte ponovo !");
                   
                }

            } while (lozinka != unos);                     //Petlja se ponavlja beskonacno dok god se ne unese true podatak

        }
    }
}
