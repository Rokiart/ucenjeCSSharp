using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Zadaci2
    { 
        static void Main(string[] args)
        {
            //Napišite program koji za učitani polumjer kruga r izračunava površinu i opseg kruga.
            //Ako polumjer nije ispravno zadan(manji od nule) program ispisuje poruku "Niste unijeli dobar polumjer!" te program završava.
            //Ako je unesen ispravan polumjer kruga potrebno je ispisati poruku: "Površina i opseg kruga s polumjerom r iznosi: P = ?, O = ?!".
            //Za vrijednost π koristiti 3.14.Broj decimalnih mjesta u ispisu nije bitan. 
            //Npr.ako korisnik preko tipkovnice za polumjer učita vrijednost 2.5 potrebno je ispisati:
            //"Površina i opseg kruga s polumjerom 2.5 iznosi: P = 19.625, O = 15.7!".


            // Console.Write("Unesite polumjer kruga r = ");

            //double r = Convert.ToDouble(Console.ReadLine());//Program uvjek cita prvo desnu stranu jednakosti. Dakle po matematickim pravilima prvo ocitava unutar zagrade
            // dakle : "Console.ReadLine" , potom uneseni string pretvara sa naredbom "Convert.ToDouble" u double (decimalni broj) ,
            // te ga dodjeljuje varijabli "r" . Ljeva strana od jednakosti se naziva "Deklaracija od r " ,a desna strana "Inicijalizacija od r"
            //if ( r>=0 )                                     //ako je r veci ili jednako 0 ulazi u blok naredbe
            //{
            // double P = Math.Pow(r, 2) * Math.PI;        //Napravio sam novu varijablu "P" povrsina te uvrstio jednadzbu za izracun povrsine kruga
            //"Math.Pow (r,2)= potencija r na drugu " puta PI (3.14) . Sve matematicke funkcije u programu se vracaju kao double
            //double O = 2 * r * Math.PI;                 // Nova varijabla "O" , opseg . Te formula za izracun opsega kruga

            // Console.WriteLine("Površina i opseg kruga s polumjerom " + r + " iznosi: P =  " + Math.Round(P,2) + " , " + " O = " + Math.Round(O ,3) + " ! "); // Funkcija Math.Round zaokruzuje rezultat na (P  na 2 decimale ,a O na 3 decimale)
            // }
            //else
            //{
            // Console.WriteLine("Niste unijeli dobar polumjer!");
            //}


            //************************************************************************************************************************************************
            //Napišite metodu ZbrojKvadrata koja kao argument prima dva prirodna broja te vraća zbroj kvadrata predanih brojeva.
            // Učitavanje dva prirodna broja, poziv metode ZbrojKvadrata te ispis rezultata potrebno je napraviti unutar Main metode.
            //Za kvadriranje je potrebno koristiti ugrađene matematičke metode.
            //Npr.ako korisnik preko tipkovnice unese brojeve 5 i 6 potrebno je ispisati: "Zbroj kvadrata brojeva 5 i 6 iznosi: 61!". 

            Console.WriteLine("Upisi 1. broj : ");

            int x = Convert.ToInt32(Console.ReadLine());   // Pošto se radi s prirodnim brojevima (cijeli brojevi) , konvertirali smo novu varijablu "x" u intidjer ima int 16 ,32 , 64 ( količina zauzeca memorije)

            Console.WriteLine("Upisi 2. broj : ");



            int y = Convert.ToInt32(Console.ReadLine());

            //Metode su izdvojeni djelovi koda koje kreiramo kako bi za nas odradili izracun

            double zbroj = ZbrojKvadrata(x,y);     //Pozvao sam metodu tako sto sam ispiso njeno ime "ZbrojKvadrata" , rezultat metode se unosi u novu varijablu "zbroj"
                                                   //koja mora bit double pošto izracun u metodi se uvjek vraca kao decimalni broj ovisno o racunici .
                                                   //Naredbe "Console.ReadLine()" , "Console.WriteLine()" su isto metode ali su integrirane u jezik
                                                   //pa im mi ne odredjujemo funkciju nego imaju zadanu funkciju te u zagradama nemaju dodatne argumente .Dok u mojoj metodi "ZbrojKvadrata(x,y)"
                                                   //maramo imat argumente s kojima ce metoda radit

            Console.WriteLine("Zbroj kvadrata brojeva " + x + " i " + y + " iznosi : " + zbroj + " !");

            //Što se tice metode imamo pocetnu "  static void Main(string[] args) " metodu . "Main" je ime metode , u zagradi su "args" argumenti , "string[]" to su nizovi stringova 
            //argumenti su potrebni metodi da zna sta ce racunati . "void" je tip metode , ako je umjesto void  "int" to bi znacilo da ce vracat cijeli broj ,
            //a "void" je metoda koja nigdje nista nevraca ."static" znaci da ta metoda nije vezana uz instancu neke klase , nije vezana uz objekt




        }
        static double ZbrojKvadrata(int x , int y)   //Metodu pisemo izvan Main metode , mogli smo ju pisat i iznad Main metode . double - vratit ce decimalni rezultat,
                                                     //"ZbrojKvadrata" - ime metode , U zagradi argumenti s kojima cemo raditi .Otvaramo zagrade unutar kojih ce metoda raditi
                                                     // Umjesto x i y ako upisemo neko drugo ime varijable . Metoda ce ih smatrat kao x i y  .npr "static double ZbrojKvadrata(int a , int b)".
                                                     // U tom slucaju moramo samo koristit unutar metode varijable a i b . 

        {
            double rezultat = Math.Pow(x, 2) + Math.Pow(y, 2); //kreiro sam novu varijablu tipa double "rezultat" , uvrstena trazena jednadjba Zbroj kvadrata od x i y
            return rezultat;                                   // "return" povratak izracuna metode "rezultat"  u pozvanu metodu "ZbrojKvadrata"
        }
















    }
}
