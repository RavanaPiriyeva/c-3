using System;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region task 1
            // 1.Verilmiş string dəyərində verilmiş char-ın hansı index-də yerləşdiyini tapıb qaytaran metod.
            // Misalçün metodu call edib "salam" və 'l' dəyərləri göndərsək geriyə 2 qaytarmalıdır amma char həmin string-də olmasa - 1 qaytarmalıdır.


            // Console.WriteLine("string daxil et :");
            // string wordss = Console.ReadLine();
            //int findIndex = FindIndex(wordss,'l');
            // Console.WriteLine("char indeksi:");
            // Console.WriteLine(findIndex);
            #endregion

            #region task 2 
            //Verilmiş  ədədin ən yaxın aşağı kökaltısını tapıb qaytaran metod.


            //Console.WriteLine("ededi daxil et:");
            //string numstr = Console.ReadLine();
            //int number = Convert.ToInt32(numstr);
            //int squareRoot =FindSquareRoot(number);
            //Console.WriteLine("en yaxin kok altisi :");
            //Console.WriteLine( squareRoot );
            #endregion

            #region task 3

            // Verilmiş ədədin rəqəmləri cəmini tapıb qaytaran metod.

            //Console.WriteLine("Eded daxil edin :");
            //string numberstr = Console.ReadLine();
            //int number = Convert.ToInt32(numberstr);
            //int sum = Sum(number);
            //Console.WriteLine("Reqemlerin cemi:");
            //Console.WriteLine(sum);

            #endregion

            #region task 4
            //Verilmiş  integer array-in icindəki ən böyük dəyəri tapan metod


            //Console.WriteLine("Nece eded daxiledilmelidi ?");
            //int size = Convert.ToInt32(Console.ReadLine());
            //int [] numbers = new int[size];
            //Console.WriteLine("Ededleri daxil et:");
            //for(int i = 0; i < numbers.Length; i++)
            //{
            //    numbers[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //int max = FindMax(numbers);
            //Console.WriteLine("En boyuk eded:");
            //Console.WriteLine(max);
            #endregion

            #region task 5

            //Verilmiş    integer  array -in  bütün elementlərini  musbet şəkildə qaytaran metod.Misalçün parametr olaraq { 1,-4,9,-8}
            // dəyərləri olan array daxil edilsə arqument kimi metod bizə { 1,4,9,8}   dəyərləri olan array qaytarmalıdır.


            //Console.WriteLine("Reqemlerin sayini daxil et :");
            //int size = Convert.ToInt32(Console.ReadLine());
            //int[] numbers = new int[size];

            //Console.WriteLine("Reqemleri daxil et :");
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    numbers[i] = Convert.ToInt32(Console.ReadLine());
            //}

            //Console.WriteLine("Yeni siyahi :");
            //foreach (var item in ChangePositive(numbers))
            //{
               
            //    Console.WriteLine(item);
            //}
            #endregion
        }
        static int FindIndex(string words, char x)
        {
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i] == x)
                {
                    return i;
                }
              

            } 
            return -1;
        }
        static int FindSquareRoot (int num)
        {
            int result = 0;
            for( int i = 0; i*i <= num; i++)
            {
              result = i;
            }
            return result;
        }
        static int Sum (int num)
        {
            int sum = 0;
            while (num > 0)
            {
                sum += (num % 10);
                num /= 10;
            }
            return sum;
        }
        static int FindMax(int [] nums)
        {
            int max = 0;
            for(int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > max)
                {
                    max = nums[i];
                }

            }
            return max;
        }
        static int[] ChangePositive (int [] nums)
        {

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] < 0)
                {
                   nums[i] = -nums[i];
                }
                else
                {
                    nums[i] = nums[i];
                }
            }
            return nums;
        }
    }
}
