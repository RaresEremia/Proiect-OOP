﻿using Proiect_OOP;
using System;


class Program
{
    static void Main()
    {
        // Testare pentru Fractie<int>
        Fractie<int> frac1 = new Fractie<int>(1, 2);
        Fractie<int> frac2 = new Fractie<int>(3, 4);
        Fractie<int> resultAdd = frac1 + frac2;
        Fractie<int> resultSub = frac1 - frac2;
        Fractie<int> resultNeg = -frac1;
        Fractie<int> resultMul = frac1 * frac2;
        Fractie<int> resultDiv = frac1 / frac2;
        Fractie<int> resultExplicit = (Fractie<int>)5;

        Console.WriteLine("Suma: " + resultAdd);
        Console.WriteLine("Deferenta: " + resultSub);
        Console.WriteLine("Negativ: " + resultNeg);
        Console.WriteLine("Inmultire: " + resultMul);
        Console.WriteLine("Impărtire: " + resultDiv);
        Console.WriteLine("Conversie: " + resultExplicit + "\n");

        // Testare pentru GaussInt
        GaussInt g1 = new GaussInt(1, 1);
        GaussInt g2 = new GaussInt(2, 3);
        Fractie<GaussInt> gfrac1 = new Fractie<GaussInt>(g1, g2);
        GaussInt g3 = new GaussInt(4, -1);
        GaussInt g4 = new GaussInt(3, 2);
        Fractie<GaussInt> gfrac2 = new Fractie<GaussInt>(g3, g4);
        Fractie<GaussInt> gresultAdd = gfrac1 + gfrac2;
        Fractie<GaussInt> gresultSub = gfrac1 - gfrac2;
        Fractie<GaussInt> gresultNeg = -gfrac1;
        Fractie<GaussInt> gresultMul = gfrac1 * gfrac2;
        Fractie<GaussInt> gresultDiv = gfrac1 / gfrac2;

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
