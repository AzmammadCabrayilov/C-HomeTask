using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Fibonacci

            //Console.WriteLine("Ededi daxil edin");

            //int number = Convert.ToInt32(Console.ReadLine());

            //int firstNumber = 0;
            //int secondNumber = 1;
            //int fib = 0;
            //int j = 0;
            //while (j < number)
            //{
            //    Console.WriteLine(fib);
            //    firstNumber = secondNumber;
            //    secondNumber = fib;
            //    fib = firstNumber + secondNumber;
            //    j++;
            //}

            //Bubble sort

            //int[] nums = new int [] { 99, 21, 48, 445, 32, 11 };
            //int temp;
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    for (int j = 0; j < nums.Length-1; j++)
            //    {
            //        if (nums[j]>nums[j+1])
            //        {
            //            temp = nums[j];
            //            nums[j] = nums[j + 1];
            //            nums[j + 1] = temp;
            //        }
            //    }
            //    //Console.WriteLine(nums);

            //}


            //for (int i = 0; i < nums.Length; i++)
            //{
            //    Console.WriteLine(nums[i]);
            //}

            //arrrayda max ve min yerini deyis
            //int[] nums = new int[] { 69, 6, 2, 16, 23 };
            //int min = 0;
            //int max = 0;
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    if (nums[max] < nums[i])
            //    {
            //        max = i;
            //    }
            //    else if (nums[min] > nums[i])
            //    {
            //        min = i;
            //    }


            //}
            //nums[max] = nums[max] + nums[min];
            //nums[min] = nums[max] - nums[min];
            //nums[max] = nums[max] - nums[min];
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    Console.WriteLine(nums[i]);
            //}


            //istifadeciin daxil etdiyi mentde butun a herflerini e herfleri ile deyisin
            //Console.WriteLine("sozu daxil edin");
            //string text = Console.ReadLine();
            //string temp = "";
            ////for (int i = 0; i <= text.Length; i++)
            ////{
            ////    if (text[i] == 'a') {
            ////        i = 'e';
            ////    }

            ////}
            ////Console.WriteLine(text);
            //foreach(char letter in text)
            //{
            //    if(letter == 'a')
            //    {
            //        temp += 'e';

            //    }
            //    else { temp += letter; }
            //    text = temp;

            //    Console.WriteLine(text);



            //metndeki saitleri tapin
            Console.WriteLine("text daxil edin");
            string text = Console.ReadLine();
            char[] wowels = { 'a', 'o', 'u', 'e', 'i' };
            int sum = 0;
            foreach (var letter in text)
            {
                for (int i = 0; i < wowels.Length; i++)
                {
                    if (letter == wowels[i])
                    {
                        sum++;
                    }
                }
            }
            Console.WriteLine(sum);

        }
    }

    
}

