using System;

namespace PasswordStrenght
{
    public struct PasswordComplexity
    {
        public int LowerCaseMin;
        public int UpperCaseMin;
        public int DigitsMin;
        public int SymbolsMin;
        public bool AcceptsSimilarChars;
        public bool AcceptsAmbiguousChar;

        public PasswordComplexity(int lowerCaseMin, int upperCaseMin, int digitsMin, int symbolsMin, bool acceptsSimilatChars, bool acceptsAmbiguousChar)
        {
            this.LowerCaseMin = lowerCaseMin;
            this.UpperCaseMin = upperCaseMin;
            this.DigitsMin = digitsMin;
            this.SymbolsMin = symbolsMin;
            this.AcceptsSimilarChars = acceptsSimilatChars;
            this.AcceptsAmbiguousChar = acceptsAmbiguousChar;
        }
    }

    class Program
    {
        static void Main()
        {
            string password = Console.ReadLine();
            PasswordComplexity passComplex;
            passComplex.LowerCaseMin = Convert.ToInt32(Console.ReadLine());
            passComplex.UpperCaseMin = Convert.ToInt32(Console.ReadLine());
            passComplex.DigitsMin = Convert.ToInt32(Console.ReadLine());
            passComplex.SymbolsMin = Convert.ToInt32(Console.ReadLine());
            passComplex.AcceptsSimilarChars = Convert.ToBoolean(Console.ReadLine());
            passComplex.AcceptsAmbiguousChar = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine(PasswordMatchesCriteria(password, passComplex));
        }

        private static bool PasswordMatchesCriteria(string password, PasswordComplexity passComplex)
        {
            if (GetLowerCaseCount() < passComplex.LowerCaseMin)
            {
                return false;
            }
            else if (GetUpperCaseCount() < passComplex.UpperCaseMin)
            {
                return false;
            }
            else if (GetDigitsCount() < passComplex.DigitsMin)
            {
                return false;
            }

            return true;
        }

        private static int GetDigitsCount()
        {
            throw new NotImplementedException();
        }

        private static int GetUpperCaseCount()
        {
            throw new NotImplementedException();
        }

        private static int GetLowerCaseCount()
        {
            throw new NotImplementedException();
        }
    }
}
