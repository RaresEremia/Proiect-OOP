using System;

namespace Proiect_OOP
{
    public class Fractie<T> where T : struct
    {
        public T Numarator { get; private set; }
        public T Numitor { get; private set; }

        public Fractie(T numarator, T numitor)
        {
            if (numitor.Equals(default(T)))
            {
                throw new ArgumentException("Numitorul nu poate fi zero");
            }

            Numarator = numarator;
            Numitor = numitor;
            Simplify();
        }
        public Fractie()
        {
            Numarator = default(T);
            Numitor = (T)Convert.ChangeType(1, typeof(T)); 
        }
        public Fractie(Fractie<T> other)
        {
            Numarator = other.Numarator;
            Numitor = other.Numitor;
        }
        ~Fractie()
        {

        }
        public void ReadFromConsole()
        {
            Console.Write("Enter numarator: ");
            Numarator = (T)Convert.ChangeType(Console.ReadLine(), typeof(T));

            Console.Write("Enter numitor: ");
            Numitor = (T)Convert.ChangeType(Console.ReadLine(), typeof(T));

            if (Numitor.Equals(default(T)))
            {
                throw new ArgumentException("Numitor nu poate fi  zero");
            }

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

        public static Fractie<T> operator +(Fractie<T> a, Fractie<T> b)
        {
            T num = Adunare(Inmultire(a.Numarator, b.Numitor), Inmultire(b.Numarator, a.Numitor));
            T denom = Inmultire(a.Numitor, b.Numitor);
            return new Fractie<T>(num, denom);
        }

        public static Fractie<T> operator -(Fractie<T> a, Fractie<T> b)
        {
            T num = Scadere(Inmultire(a.Numarator, b.Numitor), Inmultire(b.Numarator, a.Numitor));
            T denom = Inmultire(a.Numitor, b.Numitor);
            return new Fractie<T>(num, denom);
        }

        public static Fractie<T> operator -(Fractie<T> a)
        {
            return new Fractie<T>(Negate(a.Numarator), a.Numitor);
        }

        public static Fractie<T> operator *(Fractie<T> a, Fractie<T> b)
        {
            T num = Inmultire(a.Numarator, b.Numarator);
            T denom = Inmultire(a.Numitor, b.Numitor);
            return new Fractie<T>(num, denom);
        }

        public static Fractie<T> operator /(Fractie<T> a, Fractie<T> b)
        {
            if (b.Numarator.Equals(default(T)))
            {
                throw new DivideByZeroException();
            }

            T num = Inmultire(a.Numarator, b.Numitor);
            T denom = Inmultire(a.Numitor, b.Numarator);
            return new Fractie<T>(num, denom);
        }

        public static explicit operator Fractie<T>(T value)
        {
            return new Fractie<T>(value, (T)Convert.ChangeType(1, typeof(T)));
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
