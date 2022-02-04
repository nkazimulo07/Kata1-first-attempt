namespace Kata1Calculator2
{
    public class Kata1
    {
        private static int index;
        public string findDelemiter(string numbers)
        {
            string delimiter = ",";
            if (numbers[0] == '/' && numbers[1] == '/')
            {
                int x = 2;
                delimiter = numbers[2].ToString();
                while (!Char.IsDigit(numbers[x]) && numbers[index] == '\n')
                {
                    delimiter = delimiter + numbers[x];
                }
            }
            return delimiter;
        }
        public int EmptyString(string numbers)
        {
            if (!string.IsNullOrEmpty(numbers) && numbers.Any(char.IsDigit))
            {
                return AddNumbersToList(numbers);
            }
            else
            {
                return 0;
            }
        }
        public int AddNumbersToList(string numbers)
        {
            string number = null;
            string delimiter = findDelemiter(numbers);
            List<String> list = new List<String>();

            while (index < numbers.Length)
            {
                if (Char.IsDigit(numbers[index]) || (numbers[index] == '-' && Char.IsDigit(numbers[index + 1])))
                {
                    number = number + numbers[index];
                }
                if (numbers[index].ToString() == delimiter || numbers[index] == '\n')
                {
                    list.Add(number);
                    number = null;
                }
                index++;
            }
            list.Add(number);
            return Convert.ToInt32(SumNumbers(list));
        }
        public int SumNumbers(List<String> numbers)
        {
            int add = 0;
            foreach (var number in numbers)
            {
                if (Convert.ToInt32(number) < 0)
                {
                    negativeNumbers(numbers);
                }
                else if (Convert.ToInt32(number) < 1000)
                {
                    add = add + Convert.ToInt32(number);
                }
            }
            return add;
        }
        public void negativeNumbers(List<String> myList)
        {
            throw new NotImplementedException("negatives not allowed");
            foreach (var number in myList)
            {
                if (Convert.ToInt32(number) < 0)
                {
                    Console.WriteLine(number);
                }
            }
        }
    }
}