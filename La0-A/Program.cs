using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace La0_A
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //TASK1

            int low_num = 0;
            int high_num = 0;


            Console.Write("Give me your low number:");
            string v_lownumber = Console.ReadLine();
            low_num = int.Parse(v_lownumber);
            Console.WriteLine($"The low number is {low_num}");
            Console.Write("Give me your high number:");
            string v_highnumber = Console.ReadLine();
            high_num = int.Parse(v_highnumber);
            Console.WriteLine($"The high number is {high_num}");
            // Write a loop that keeps iterating until the user enters a positive low number.

            //TASK 2
            while (low_num <= 0)
            {
                Console.Write("Give me your low number:");
                low_num = int.Parse(Console.ReadLine());
            }
            high_num = low_num;
            while (high_num <= low_num)
            {
                Console.Write("Give me high number:");
                high_num = int.Parse(Console.ReadLine());

            }
            //diff num
            int diff_num = 0;
            diff_num = high_num - low_num;
            Console.WriteLine($"The differene number is {diff_num}");

            //TASK 3
            //Create an array variable that holds every number between low and high
            //int[] arr = { 1, 2, 3, 4, 5};
            int[] arr = new int[diff_num];
            for(int a = 0; a < diff_num; a++)
            {
                arr[a] = low_num + a;
            }

            //Create a new file called "numbers.txt".
            //Get path from file
            //Use Streamwriter to write file
            //Path @"C:\\TEMP\numbers.txt";
            string path = Path.GetFullPath("numbers.txt");
            //if (File.Exists(path))
            //{
            //    File.Delete(path);
            //}
            ////Create file with path
            //using (FileStream fs = File.Create(path))
            //{
            //    for (int i = arr.Length - 1; i >= 0; i--)
            //    {
            //        byte[] arr_num = new UTF8Encoding(true).GetBytes(arr[i].ToString() + "\n");
            //        fs.Write(arr_num, 0, arr_num.Length);

            //    }

            //}
            //OR
            using(StreamWriter sw=new StreamWriter(path))
            {
                for (int i = arr.Length - 1; i >= 0; i--)
                {
                    Console.WriteLine($"Revert number:{arr[i]}");
                    sw.WriteLine(arr[i]);

                }
            }
            //Use methods get and validate the users input.
            //Read the numbers back from the file and print out the sum of the numbers.
            double sum = 0;
            List<double> lst = new List<double>();
            string[] lines = File.ReadAllLines("numbers.txt");
            foreach (string line in lines)
            {
                sum += double.Parse(line);
                lst.Add(double.Parse(line));
            }
            Console.WriteLine($"The sum of the number is {sum}");
            Console.WriteLine("The prime number is");
            for(int j= lst.Count -1; j >=0; j--) 
            {
                if (lst[j] > 1)
                {
                    if (checkPrimeNumber(lst[j])==true)
                    {
                        Console.WriteLine(lst[j]);
                    }
                }
                
          
            }
         
        }
        public static bool checkPrimeNumber(double number)
        {
            int count = 0;
            int numBott = 1;//increase number divided
            while (number >= numBott)
            {

                if (number == 2)
                {
                    count = 2;
                    break;
                }
                else
                {              
                    if (number % numBott == 0)
                    {
                        count++;
                    }
                    numBott++;
                }
            }
            if (count == 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
