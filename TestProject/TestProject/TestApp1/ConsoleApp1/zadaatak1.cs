using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class zadaatak1
    {
       // public static void Main(string[] args)
        //*********************************************************************************************
        //{
        //    Console.WriteLine("unesite n:");
        //    int n = Convert.ToInt32(Console.ReadLine());

        //    Console.WriteLine("Umnozak svih prirodnih brojeva od 1 do " + n + " je " + Umnozak(n));

        //}
        //static void Main(string[] args)
        //{
        //    int umnozak = 1;

        //    for (int i = 1; i <= brojn; i++)
        //    {
        //        umnozak = umnozak * i;

        //    }
        //    return umnozak;
        //}
        //************************************************************************************************

        //Aplikacija koja racuna kvadratnu jednadzbu.
        //{
        //  Console.WriteLine("Unesite parametar a : ");
        //    double a = Convert.ToDouble(Console.ReadLine());

        //Console.WriteLine("Unesite parametar b : ");
        //    double b = Convert.ToDouble(Console.ReadLine());


        //Console.WriteLine("Unesite parametar c : ");
        //    double c = Convert.ToDouble(Console.ReadLine());

        //double x1 = (-b + Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / (2 * a);
        ////za korjenovanje je funkcija Math.Sqrt  , za potenciju koristimo funkciju Math.Pow{ IME VARIJABLE , POTENCIJA (npr na 3 , na treču)}
        //double x2 = (-b - Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / (2 * a);

        //Console.WriteLine("x1 = " + x1);
        //    Console.WriteLine("x2 = " + x2);


        //}
        //**************************************************************************************************
        // konzolna aplikacija koja zbraja 10 brojeva koristeci FOR petlju . Koristi se kad se zna koliko će se puta ponavljaz petlja
        //{
        //    int zbroj = 0;

        //    for (int i=1; i<=10; i++)
        //    {
        //        Console.WriteLine("Unesi broj: " + i  + " . broj");

        //        int broj = Convert.ToInt32(Console.ReadLine());

        //        zbroj = zbroj + broj;

        //    }
        //    Console.WriteLine("Zbroj svih 10 brojeva je " + zbroj);
        //}
        //**************************************************************************************************
        //konzolna aplikacija koja zbraja 10 brojeva koristeci WHILE petlju . Koristi se kada se nezna koliko će se puta ponavljat petlja
        //{
        //    int zbroj = 0;
        //    int i = 1;

        //    while (i <= 10)
        //    {
        //        Console.WriteLine("Unesi broj: " + i + " . broj");

        //        int broj = Convert.ToInt32(Console.ReadLine());

        //        zbroj = zbroj + broj;
        //        i++; // bez ovog povečanja  petlje , petlja bi se ponavljala beskonačno

        //    }
        //    Console.WriteLine("Zbroj svih 10 brojeva je " + zbroj);
        //}
        //****************************************************************************************************
        //konzolna aplikacija koja zbraja 10 brojeva koristeci DO WHILE petlju , prvo izračunava petlju te provjerava uvjet 
        //{
        //    int zbroj = 0;
        //    int i = 1;

        //    do
        //    {
        //        Console.WriteLine("Unesi broj: " + i + " . broj");

        //        int broj = Convert.ToInt32(Console.ReadLine());

        //        zbroj = zbroj + broj;
        //        i++; // bez ovog povečanja  petlje , petlja bi se ponavljala beskonačno

        //    } while (i <= 10);
        //    Console.WriteLine("Zbroj svih 10 brojeva je " + zbroj);
        //}
        //*****************************************************************************************************
        // upisati 6 imena , te provjeriti koliko ima imena sa brojem slova manjih , jednakih i vecih od 5
        //{
        //    string[] imena = new string[6]; //definira zauzece memorijske celije pod nazivom "varijabla = imena " koje iznosi 6

        //    int BrojSlovaManjiOd5 = 0; // brojac varijable 
        //    int BrojSlovaTocno5 = 0;
        //    int BrojSlovaVeciOd5 = 0;

        //    for (int i = 0; i < imena.Length; i++) //Petlja
        //    {
        //        Console.Write("Unesite ime : " + (i + 1) + "  ");
        //        imena[i] = Console.ReadLine();

        //        if (imena[i].Length < 5)
        //        {
        //            BrojSlovaManjiOd5++;

        //        }
        //        if (imena[i].Length == 5)
        //        {
        //            BrojSlovaTocno5++;
        //        }
        //        else
        //        {
        //            BrojSlovaVeciOd5++;
        //        }

        //        Console.WriteLine(" imena s brojem slova manjim od 5 su : " + BrojSlovaManjiOd5 + " , ");

        //        Console.WriteLine(" imena s brojem slova  od 5 su : " + BrojSlovaTocno5 + " , ");

        //        Console.WriteLine(" imena s brojem slova večim od 5 su : " + BrojSlovaVeciOd5 + " , ");

        //    }

        //}
        //*************************************************************************************************
       
    }
}
