
namespace Lab14
{
    [DeveloperInfo("Гульназ", "5 декабря, 2023")]
    internal class RationalNumbers
    {
        private int numerator;//числитель 
        private int denominator; //знаменатель
        public int Numerator { get { return numerator; } set { numerator = value; } }
        public int Denominator {get { return denominator;} set { denominator = value; } }
        public RationalNumbers()
        {

        }
        public RationalNumbers(int numerator, int denominator)
        {
            this.numerator = numerator;
            this.denominator = denominator;
        }

        public static bool operator ==(RationalNumbers r1, RationalNumbers r2)
        {
            if (r1 == r2)
            {
                return true;
            }
            if (r1 is null || r2 is null)
            {
                return false;
            }
            return r1.numerator * r2.denominator == r2.numerator * r1.denominator;
        }

        public static bool operator !=(RationalNumbers r1, RationalNumbers r2)
        {
            if (r1 != r2)
            {
                return true;
            }
            if (r1 is null || r2 is null)
            {
                return false;
            }
            return r1.numerator * r2.denominator != r2.numerator * r1.denominator;
        }
        //return r1.numerator * r2.denominator < r2.numerator * r1.denominator;

        public static bool operator <(RationalNumbers r1, RationalNumbers r2)
        {
            return r1.numerator * r2.denominator < r2.numerator * r1.denominator;
        }

        public static bool operator >(RationalNumbers r1, RationalNumbers r2)
        {
            return r1.numerator * r2.denominator > r2.numerator * r1.denominator;
        }

        public static bool operator <=(RationalNumbers r1, RationalNumbers r2)
        {
            return r1 < r2 || r1 == r2;
        }

        public static bool operator >=(RationalNumbers r1, RationalNumbers r2)
        {
            return r1 > r2 || r1 == r2;
        }

        public static RationalNumbers operator +(RationalNumbers r1, RationalNumbers r2)
        {
            return new RationalNumbers(r1.Numerator * r2.Denominator + r2.Numerator * r1.Denominator, r1.Denominator * r2.Denominator);
        }

        public static RationalNumbers operator -(RationalNumbers r1, RationalNumbers r2)
        {
            return new RationalNumbers(r1.Numerator * r2.Denominator - r2.Numerator * r1.Denominator, r1.Denominator * r2.Denominator);
        }

        public static RationalNumbers operator ++(RationalNumbers r1)
        {
            return new RationalNumbers(r1.Numerator + r1.Denominator, r1.Denominator);
        }

        public static RationalNumbers operator --(RationalNumbers r1)
        {
            return new RationalNumbers(r1.Numerator - r1.Denominator, r1.Denominator);
        }

        public override string ToString()
        {
            return $"{numerator}/{denominator}";
        }

        public static explicit operator float(RationalNumbers r1)
        {
            return (float)r1.numerator / r1.denominator;
        }
        public static explicit operator int(RationalNumbers r1)
        {
            return r1.numerator / r1.denominator;
        }

        public static RationalNumbers operator *(RationalNumbers r1, RationalNumbers r2)
        {
            return new RationalNumbers(r1.Numerator * r2.Numerator, r1.Denominator * r2.Denominator);
        }

        public static RationalNumbers operator /(RationalNumbers r1, RationalNumbers r2)
        {
            return new RationalNumbers(r1.Numerator * r2.Denominator, r1.Denominator * r2.Numerator);
        }

        public static RationalNumbers operator %(RationalNumbers r1, RationalNumbers r2)
        {
            int R1 = r1.Numerator * r2.Denominator;
            int R2 = r1.Denominator * r2.Numerator;
            return new RationalNumbers(R1 % R2, r1.Denominator * r2.Denominator);
        }
    }
}
