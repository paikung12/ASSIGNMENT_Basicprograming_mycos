using System;

namespace Classlibrary1
{
    public class Class1
    {
        public bool ArmstrongNumber(int number)
        {
            int sum = 0;
            int rem;
            bool IsArmstrongNumber = false;
            for (int i = number; i > 0; i = i / 10)
            {
                rem = i % 10;
                sum = sum + rem * rem * rem;
            }
            if (sum == number)
            {
                IsArmstrongNumber = true;
            }
           
            retrun IsArmstrongNumber;
        }

        public int StrongNumber(int number)
        {
            int fact;
            int num = number;
            int sum = 0;

            while (number != 0)
            {
                fact = 1;

                for (int i = 1; i <= number % 10; ++i)
                    fact *= i;

                sum += fact;

                number /= 10;
            }
            if (sum == num)
            {
                Console.WriteLine(num + " is a strong number");
                return sum;
            }
            else
            {
                Console.WriteLine(num + " is not a strong number");
                return sum;

            }

        }
        public string RemoveVowels(string text)
        {
            string newText = text.Replace("a", string.Empty)
                              .Replace("e", string.Empty)
                              .Replace("i", string.Empty)
                              .Replace("o", string.Empty)
                              .Replace("u", string.Empty)
                              .Replace("y", string.Empty);

            Console.WriteLine(newText);
            return newText;
        }
        public string RemoveParentheses(string text)
        {
            string newText = text.Replace("(", string.Empty)
                              .Replace(")", string.Empty);


            Console.WriteLine(newText);
            return newText;
        }

        public int[] ArrayRotation(int[] arr)
        {
            Console.WriteLine("\nArray1: [{0}]", string.Join(", ", arr));
            var temp = arr[0];
            for (var i = 0; i < arr.Length - 1; i++)
            {
                arr[i] = arr[i + 1];
            }
            arr[arr.Length - 1] = temp;
            Console.WriteLine("\nAfter rotating array becomes: [{0}]", string.Join(", ", arr));
            return arr;
        }
        public int Thesecondsmallest(int[] arr)
        {
           
            Array.Sort(arr);
            return arr[1];
          
        }
       
    }
}
