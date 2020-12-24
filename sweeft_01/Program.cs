using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;

namespace sweeft_01
{
    class Program
    {
        static void Main(string[] args)
        {
            CheckIsPalindrome();

            CheckMinSplit();

            CheckNotContains();

            CheckIsProperly();

            CheckCountVariants();

            CheckLinkedStructure();

            CheckExchangeRate();

            Console.ReadLine();
        }

        public static void CheckIsPalindrome()
        {
            bool isPalindromeAnswer;
            isPalindromeAnswer = Methods.IsPalindrome("wasdsaw");
            Console.WriteLine(isPalindromeAnswer);
            isPalindromeAnswer = Methods.IsPalindrome("wassaw");
            Console.WriteLine(isPalindromeAnswer);
            isPalindromeAnswer = Methods.IsPalindrome("wadsaw");
            Console.WriteLine(isPalindromeAnswer);
            Console.WriteLine("\n");
        }

        public static void CheckMinSplit()
        {
            int minSplitAnswer;
            for (int i = 0; i < 50; i++)
            {
                minSplitAnswer = Methods.MinSplit(i);
                Console.WriteLine(i + "   " + minSplitAnswer);
            }
            Console.WriteLine("\n");
        }

        public static void CheckNotContains()
        {
            int notContainsAnswer;
            notContainsAnswer = Methods.NotContains(new int[] { 1, 2, 3, 4, 5 });
            Console.WriteLine(notContainsAnswer);
            notContainsAnswer = Methods.NotContains(new int[] { 5, 4, 3, 2, 1, 0 });
            Console.WriteLine(notContainsAnswer);
            notContainsAnswer = Methods.NotContains(new int[] { 1, 2, 6, 4, 5 });
            Console.WriteLine(notContainsAnswer);
            notContainsAnswer = Methods.NotContains(new int[] { -54, -5, 45, 0, 23, 1, 2, 3, -1, -2, -3, 0, 3 });
            Console.WriteLine(notContainsAnswer);
            Console.WriteLine("\n");
        }

        public static void CheckIsProperly()
        {
            bool isProperlyAnswer;
            isProperlyAnswer = Methods.IsProperly("(())");
            Console.WriteLine(isProperlyAnswer);
            isProperlyAnswer = Methods.IsProperly("()()");
            Console.WriteLine(isProperlyAnswer);
            isProperlyAnswer = Methods.IsProperly("(()())");
            Console.WriteLine(isProperlyAnswer);
            isProperlyAnswer = Methods.IsProperly("(()))");
            Console.WriteLine(isProperlyAnswer);
            isProperlyAnswer = Methods.IsProperly("(())(");
            Console.WriteLine(isProperlyAnswer);
            isProperlyAnswer = Methods.IsProperly("((()())");
            Console.WriteLine(isProperlyAnswer);
            Console.WriteLine("\n");
        }

        public static void CheckCountVariants()
        {
            int countVariantsAnswer;
            for (int i = 1; i <= 20; i++)
            {
                countVariantsAnswer = Methods.CountVariants(i);
                Console.WriteLine(i + "   " + countVariantsAnswer);
            }
            Console.WriteLine("\n");
        }

        public static void CheckLinkedStructure()
        {
            LinkedStructure linkedStructure = new LinkedStructure();

            linkedStructure.Add("qwe1");
            linkedStructure.Add("qwe2");
            linkedStructure.Add("qwe3");
            linkedStructure.Add("qwe4");
            linkedStructure.Add("qwe5");
            linkedStructure.Add("qwe6");
            linkedStructure.Add("qwe7");
            linkedStructure.Add("qwe8");
            linkedStructure.Add("qwe9");
            linkedStructure.Remove("qwe2");
            linkedStructure.Remove("qwe1");
            linkedStructure.Remove("qwe4");
            linkedStructure.Remove("qwe6");
            linkedStructure.Remove("qwe8");
            linkedStructure.Remove("qwe9");

        }

        public static void CheckExchangeRate()
        {
            double exchangeRateAnswer;
            exchangeRateAnswer = Methods.ExchangeRate("USD", "EUR");
            Console.WriteLine(exchangeRateAnswer);
            exchangeRateAnswer = Methods.ExchangeRate("USD", "GEL");
            Console.WriteLine(exchangeRateAnswer);
            exchangeRateAnswer = Methods.ExchangeRate("USD", "RUB");
            Console.WriteLine(exchangeRateAnswer);
            exchangeRateAnswer = Methods.ExchangeRate("AZN", "EUR");
            Console.WriteLine(exchangeRateAnswer);
            exchangeRateAnswer = Methods.ExchangeRate("USD", "TRY");
            Console.WriteLine(exchangeRateAnswer);
            Console.WriteLine("\n");
        }


    }
}
