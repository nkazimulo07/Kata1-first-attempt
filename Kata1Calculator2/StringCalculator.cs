using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace Kata1Calculator2
{
    public class StringCalculator
    {
        public int Add(string numbers)
        {
            var delimiter = "";
            if (string.IsNullOrEmpty(numbers))
            {
                return 0;
            }

            numbers = RemoveSlash(numbers); 
            delimiter = GetDelimiter(numbers);
            string[] splitNumbers = numbers.Split(new string[] { ",", "\n", delimiter }, StringSplitOptions.RemoveEmptyEntries);
            var convectedNumbers = ConvertStringArrayToIntArray(splitNumbers);

            return SumOfNumbers(convectedNumbers);
        }
        private string RemoveSlash(string number)
        {
            if (number.Contains("//"))
            {
                number = number.Substring(2);
            }

            return number;
        }

        private string GetDelimiter(string numbers)
        {
            var delimiter = "";
            var count = 1;
            if (!Char.IsDigit(numbers[0]))
            {
                delimiter = numbers[0].ToString();

                while (!Char.IsDigit(numbers[count]) && numbers[count] != '\n')
                {
                    delimiter = delimiter + numbers[count].ToString();
                    count++;
                }
            }

            return delimiter;
        }

        private int[] ConvertStringArrayToIntArray(string[] numbers)
        {
            var result = new int[numbers.Length];

            for (var i = 0; i < numbers.Length; i++)
            {
                result[i] = Convert.ToInt32(numbers[i]);
            }

            return result;
        }

        private int SumOfNumbers(int[] numbers)
        {
            var sumOfNumbers = 0;

            foreach (int number in numbers)
            {
                if(number < 0)
                {
                    negativeNumbers(numbers);
                }
                else if(number < 1000)
                {
                    sumOfNumbers = sumOfNumbers + number;
                }
                
            }

            return sumOfNumbers;
        }

        private List<int> negativeNumbers(int[] numbers)
        {
            throw new NotImplementedException("negatives not allowed");
            List<int> negativeNumbers = new List<int>();
            foreach (int number in numbers)
            {
                if (number < 0)
                {
                  negativeNumbers.Add(number);
                }
            }
            return negativeNumbers;
        }
    }
}
