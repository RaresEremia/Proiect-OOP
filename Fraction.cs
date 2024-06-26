using System;

namespace Proiect_OOP
{
    public class Fraction<T> where T : struct
    {
        public T Numarator { get; private set; }
        public T Numitor { get; private set; }

        public Fraction(T numarator, T numitor)
        {
            if (numitor.Equals(default(T)))
            {
                throw new ArgumentException("Numitorul nu poate fi zero");
            }

            Numarator = numarator;
            Numitor = numitor;
            Simplify();
        }

        private void Simplify()
        {
            if (typeof(T) == typeof(GaussInt))
            {
                return;
            }

            T cmmdc = CelMaiMareDivizorComun(Numarator, Numitor);
            Numarator = Impartire(Numarator, cmmdc);
            Numitor = Impartire(Numitor, cmmdc);
        }

        private static T CelMaiMareDivizorComun(T a, T b)
        {
            if (typeof(T) == typeof(GaussInt))
            {
                throw new InvalidOperationException("CMMDC nu este suportat pe numere reale/GaussInt.");
            }

            while (!b.Equals(default(T)))
            {
                T temp = b;
                b = Mod(a, b);
                a = temp;
            }
            return a;
        }

        public static Fraction<T> operator +(Fraction<T> a, Fraction<T> b)
        {
            T num = Adunare(Inmultire(a.Numarator, b.Numitor), Inmultire(b.Numarator, a.Numitor));
            T denom = Inmultire(a.Numitor, b.Numitor);
            return new Fraction<T>(num, denom);
        }

        public static Fraction<T> operator -(Fraction<T> a, Fraction<T> b)
        {
            T num = Scadere(Inmultire(a.Numarator, b.Numitor), Inmultire(b.Numarator, a.Numitor));
            T denom = Inmultire(a.Numitor, b.Numitor);
            return new Fraction<T>(num, denom);
        }

        public static Fraction<T> operator -(Fraction<T> a)
        {
            return new Fraction<T>(Negate(a.Numarator), a.Numitor);
        }

        public static Fraction<T> operator *(Fraction<T> a, Fraction<T> b)
        {
            T num = Inmultire(a.Numarator, b.Numarator);
            T denom = Inmultire(a.Numitor, b.Numitor);
            return new Fraction<T>(num, denom);
        }

        public static Fraction<T> operator /(Fraction<T> a, Fraction<T> b)
        {
            if (b.Numarator.Equals(default(T)))
            {
                throw new DivideByZeroException();
            }

            T num = Inmultire(a.Numarator, b.Numitor);
            T denom = Inmultire(a.Numitor, b.Numarator);
            return new Fraction<T>(num, denom);
        }

        public static explicit operator Fraction<T>(T value)
        {
            return new Fraction<T>(value, (T)Convert.ChangeType(1, typeof(T)));
        }

        public override string ToString()
        {
            return $"{Numarator}/{Numitor}";
        }

        private static T Adunare(T a, T b)
        {
            if (typeof(T) == typeof(GaussInt))
            {
                return (T)(object)(((GaussInt)(object)a) + ((GaussInt)(object)b));
            }
            return (T)Convert.ChangeType(Convert.ToDouble(a) + Convert.ToDouble(b), typeof(T));
        }

        private static T Scadere(T a, T b)
        {
            if (typeof(T) == typeof(GaussInt))
            {
                return (T)(object)(((GaussInt)(object)a) - ((GaussInt)(object)b));
            }
            return (T)Convert.ChangeType(Convert.ToDouble(a) - Convert.ToDouble(b), typeof(T));
        }

        private static T Inmultire(T a, T b)
        {
            if (typeof(T) == typeof(GaussInt))
            {
                return (T)(object)(((GaussInt)(object)a) * ((GaussInt)(object)b));
            }
            return (T)Convert.ChangeType(Convert.ToDouble(a) * Convert.ToDouble(b), typeof(T));
        }

        private static T Impartire(T a, T b)
        {
            if (typeof(T) == typeof(GaussInt))
            {
                return (T)(object)(((GaussInt)(object)a) / ((GaussInt)(object)b));
            }
            return (T)Convert.ChangeType(Convert.ToDouble(a) / Convert.ToDouble(b), typeof(T));
        }

        private static T Mod(T a, T b)
        {
            if (typeof(T) == typeof(GaussInt))
            {
                throw new InvalidOperationException("Mod nu este suportat pe numere reale/GaussInt.");
            }
            return (T)Convert.ChangeType(Convert.ToDouble(a) % Convert.ToDouble(b), typeof(T));
        }

        private static T Negate(T a)
        {
            if (typeof(T) == typeof(GaussInt))
            {
                GaussInt ga = (GaussInt)(object)a;
                return (T)(object)new GaussInt(-ga.Real, -ga.Imag);
            }
            return (T)Convert.ChangeType(-Convert.ToDouble(a), typeof(T));
        }
    }
}
