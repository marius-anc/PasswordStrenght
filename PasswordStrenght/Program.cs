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

    public class Program
    {
        public static bool PasswordMatchesCriteria(string password, PasswordComplexity passComplex)
        {
            if (GetLowerCaseCount(password) < passComplex.LowerCaseMin)
            {
                return false;
            }

            if (GetUpperCaseCount(password) < passComplex.UpperCaseMin)
            {
                return false;
            }

            if (GetDigitsCount(password) < passComplex.DigitsMin)
            {
                return false;
            }

            if (GetSymbolCount(password) < passComplex.SymbolsMin)
            {
                return false;
            }

            if (!passComplex.AcceptsSimilarChars && ContainsSimilarChars(password))
            {
                return false;
            }

            if (!passComplex.AcceptsAmbiguousChar && ContainsAmigousChars(password))
            {
                return false;
            }

            return true;
        }

        public static bool ContainsAmigousChars(string password)
        {
            foreach (char ambigousChar in "{}[]()/\'\"~,;.<> ")
            {
                if (password.Contains(ambigousChar))
                {
                    return true;
                }
            }

            return false;
        }

        public static bool ContainsSimilarChars(string password)
        {
            foreach (char similarChar in "l1Io0O")
            {
                if (password.Contains(similarChar))
                {
                    return true;
                }
            }

            return false;
        }

        public static int GetSymbolCount(string password)
        {
            if (password == null)
            {
                throw new ArgumentNullException(nameof(password));
            }

            int lowerCaseCount = 0;

            foreach (char letter in password)
            {
                if (!char.IsLetterOrDigit(letter))
                {
                    lowerCaseCount++;
                }
            }

            return lowerCaseCount;
        }

        public static int GetDigitsCount(string password)
        {
            if (password == null)
            {
                throw new ArgumentNullException(nameof(password));
            }

            int lowerCaseCount = 0;

            foreach (char letter in password)
            {
                if (char.IsDigit(letter))
                {
                    lowerCaseCount++;
                }
            }

            return lowerCaseCount;
        }

        public static int GetUpperCaseCount(string password)
        {
            if (password == null)
            {
                throw new ArgumentNullException(nameof(password));
            }

            int lowerCaseCount = 0;

            foreach (char letter in password)
            {
                if (char.IsUpper(letter))
                {
                    lowerCaseCount++;
                }
            }

            return lowerCaseCount;
        }

        public static int GetLowerCaseCount(string password)
        {
            if (password == null)
            {
                throw new ArgumentNullException(nameof(password));
            }

            int lowerCaseCount = 0;

            foreach (char letter in password)
            {
                if (char.IsLower(letter))
                    {
                    lowerCaseCount++;
                }
            }

            return lowerCaseCount;
        }

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
    }
}
