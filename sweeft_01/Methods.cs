using System;
using System.IO;
using System.Net;

namespace sweeft_01
{
    public class Methods
    {

        public static bool IsPalindrome(string text)
        {
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] != text[text.Length - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }

        public static int MinSplit(int amount)
        {
            if (amount == 0)
            {
                return 0;
            }
            int dataOut = 0;
            int[] value = { 50, 20, 10, 5, 2, 1 };
            int sum = 0;

            for (int i = 0; i < value.Length; i++)
            {
                if (sum + value[i] <= amount)
                {
                    sum += value[i];
                    dataOut++;
                    i = -1;
                    if (sum == amount)
                    {
                        return dataOut;
                    }
                }
            }
            return dataOut;
        }

        public static int NotContains(int[] array)
        {
            int dataOut = 1;
            for (int i = 0; i < array.Length; i++)
            {
                if (dataOut == array[i])
                {
                    dataOut++;
                    i = -1;
                }
            }
            return dataOut;
        }

        public static bool IsProperly(string sequence)
        {
            int charOpened = 0, charClosed = 0;
            for (int i = 0; i < sequence.Length; i++)
            {
                if (sequence[i] == '(') charOpened++;
                else if (sequence[i] == ')')
                {
                    if (charOpened == 0) return false;
                    charOpened--;
                }
                else return false;
            }
            if (charOpened == 0 && charClosed == 0) return true;
            else return false;
        }

        public static int CountVariants(int stearsCount)
        {
            if (stearsCount == 1) return 1;
            if (stearsCount == 2) return 2;
            return (CountVariants(stearsCount - 1) + CountVariants(stearsCount - 2));
        }

        public static double ExchangeRate(string from, string to)
        {
            var webClient = new WebClient();
            Stream stream = webClient.OpenRead("http://www.nbg.ge/rss.php");
            StreamReader streamReader = new StreamReader(stream);

            string dataAll = streamReader.ReadToEnd();
            stream.Close();

            string[] dataAllSplited = dataAll.Split('\n');

            double valueFrom = -1, valueTo = -1;

            if (from == "GEL") valueFrom = 1;
            if (to == "GEL") valueTo = 1;

            for (int i = 0; i < dataAllSplited.Length; i++)
            {
                dataAllSplited[i] = dataAllSplited[i].Replace("\t", "");
                dataAllSplited[i] = dataAllSplited[i].Replace("<td>", "");
                dataAllSplited[i] = dataAllSplited[i].Replace("</td>", "");
            }

            for (int i = 0; i < dataAllSplited.Length; i++)
            {
                if (dataAllSplited[i] == from)
                {
                    int coef = Convert.ToInt32(dataAllSplited[i + 1].Split(' ')[0]);
                    valueFrom = Convert.ToDouble(dataAllSplited[i + 2].Replace('.', ',')) / coef;
                    if (valueTo > 0) break;
                }
                if (dataAllSplited[i] == to)
                {
                    int coef = Convert.ToInt32(dataAllSplited[i + 1].Split(' ')[0]);
                    valueTo = Convert.ToDouble(dataAllSplited[i + 2].Replace('.', ',')) / coef;
                    if (valueFrom > 0) break;
                }
            }

            if (valueFrom <= 0 || valueTo <= 0) return 0;

            return (valueFrom / valueTo);
        }

    }
}
