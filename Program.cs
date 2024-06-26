using Proiect_OOP;
using System;
using System.Collections.Generic;


class Program
{
    static void Main()
    {
        // Testare pentru Fractie<int>
        Fractie<int> fractie1 = new Fractie<int>();
        fractie1.ReadFromConsole();
        Fractie<int> fractie2 = new Fractie<int>();
        fractie2.ReadFromConsole();
        //Fractie<int> fractie1 = new Fractie<int>(1, 2);
        //Fractie<int> fractie2 = new Fractie<int>(3, 4);
        Fractie<int> resultAdd = fractie1 + fractie2;
        Fractie<int> resultSub = fractie1 - fractie2;
        Fractie<int> resultNeg = -fractie1;
        Fractie<int> resultMul = fractie1 * fractie2;
        Fractie<int> resultDiv = fractie1 / fractie2;
        Fractie<int> resultExplicit = (Fractie<int>)5;

        Console.WriteLine("Suma: " + resultAdd);
        Console.WriteLine("Deferenta: " + resultSub);
        Console.WriteLine("Negativ: " + resultNeg);
        Console.WriteLine("Inmultire: " + resultMul);
        Console.WriteLine("Impărtire: " + resultDiv);
        Console.WriteLine("Conversie: " + resultExplicit + "\n");

        // Testare pentru GaussInt
        GaussInt g1 = new GaussInt();
        g1.ReadFromConsole();
        GaussInt g2 = new GaussInt();
        g2.ReadFromConsole();

        //GaussInt g1 = new GaussInt(1, 1);
        //GaussInt g2 = new GaussInt(2, 3);
        Fractie<GaussInt> gfractie1 = new Fractie<GaussInt>(g1, g2);
        GaussInt g3 = new GaussInt(4, -1);
        GaussInt g4 = new GaussInt(3, 2);
        Fractie<GaussInt> gfractie2 = new Fractie<GaussInt>(g3, g4);
        Fractie<GaussInt> gresultAdd = gfractie1 + gfractie2;
        Fractie<GaussInt> gresultSub = gfractie1 - gfractie2;
        Fractie<GaussInt> gresultNeg = -gfractie1;
        Fractie<GaussInt> gresultMul = gfractie1 * gfractie2;
        Fractie<GaussInt> gresultDiv = gfractie1 / gfractie2;

        Console.WriteLine("Gauss Int Adunare: " + gresultAdd);
        Console.WriteLine("Gauss Int Scadere: " + gresultSub);
        Console.WriteLine("Gauss Int Negare: " + gresultNeg);
        Console.WriteLine("Gauss Int Înmultire: " + gresultMul);
        Console.WriteLine("Gauss Int Împărtire: " + gresultDiv + "\n");


        Console.WriteLine("Equals: " + g1.Equals(g2));
        Console.WriteLine("CompareTo: " + g1.CompareTo(g2));
        Console.WriteLine("ToString: " + g1.ToString());
        
        Console.ReadKey();
    }
}
