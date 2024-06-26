using System;

namespace Proiect_OOP
{
    public struct GaussInt 
    {
        public int Real { get; private set; }
        public int Imag { get; private set; }

        public GaussInt(int real, int imag)
        {
            Real = real;
            Imag = imag;
        }

        public int CompareTo(GaussInt other)
        {
            if (Real == other.Real)
            {
                return Imag.CompareTo(other.Imag);
            }
            return Real.CompareTo(other.Real);
        }

        public bool Equals(GaussInt other)
        {
            return Real == other.Real && Imag == other.Imag;
        }

        public static GaussInt operator +(GaussInt a, GaussInt b)
        {
            return new GaussInt(a.Real + b.Real, a.Imag + b.Imag);
        }

        public static GaussInt operator -(GaussInt a, GaussInt b)
        {
            return new GaussInt(a.Real - b.Real, a.Imag - b.Imag);
        }

        public static GaussInt operator *(GaussInt a, GaussInt b)
        {
            return new GaussInt(a.Real * b.Real - a.Imag * b.Imag, a.Real * b.Imag + a.Imag * b.Real);
        }

        public static GaussInt operator /(GaussInt a, GaussInt b)
        {
            int denom = b.Real * b.Real + b.Imag * b.Imag;
            int realPart = (a.Real * b.Real + a.Imag * b.Imag) / denom;
            int imagPart = (a.Imag * b.Real - a.Real * b.Imag) / denom;
            return new GaussInt(realPart, imagPart);
        }

        public override string ToString()
        {
            return $"{Real} + {Imag}i";
        }
    }
}
