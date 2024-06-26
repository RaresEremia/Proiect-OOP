using Proiect_OOP;
using System;


class Program
{
    static void Main()
    {
        // Testare pentru Fraction<int>
        Fraction<int> frac1 = new Fraction<int>(1, 2);
        Fraction<int> frac2 = new Fraction<int>(3, 4);
        Fraction<int> resultAdd = frac1 + frac2;
        Fraction<int> resultSub = frac1 - frac2;
        Fraction<int> resultNeg = -frac1;
        Fraction<int> resultMul = frac1 * frac2;
        Fraction<int> resultDiv = frac1 / frac2;
        Fraction<int> resultExplicit = (Fraction<int>)5;

        Console.WriteLine("Suma: " + resultAdd);
        Console.WriteLine("Deferenta: " + resultSub);
        Console.WriteLine("Negativ: " + resultNeg);
        Console.WriteLine("Inmultire: " + resultMul);
        Console.WriteLine("Impărțire: " + resultDiv);
        Console.WriteLine("Conversie: " + resultExplicit + "\n");

        // Testare pentru GaussInt
        GaussInt g1 = new GaussInt(1, 1);
        GaussInt g2 = new GaussInt(2, 3);
        Fraction<GaussInt> gfrac1 = new Fraction<GaussInt>(g1, g2);
        GaussInt g3 = new GaussInt(4, -1);
        GaussInt g4 = new GaussInt(3, 2);
        Fraction<GaussInt> gfrac2 = new Fraction<GaussInt>(g3, g4);
        Fraction<GaussInt> gresultAdd = gfrac1 + gfrac2;
        Fraction<GaussInt> gresultSub = gfrac1 - gfrac2;
        Fraction<GaussInt> gresultNeg = -gfrac1;
        Fraction<GaussInt> gresultMul = gfrac1 * gfrac2;
        Fraction<GaussInt> gresultDiv = gfrac1 / gfrac2;

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
