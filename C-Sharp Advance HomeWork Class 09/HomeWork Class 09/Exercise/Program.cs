using System;

namespace Exercise // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string appPath = @"..\..\..\";
            string folderPath = appPath + @"ExerciseFolder\";
            string filesPath = folderPath + @"Calculations.txt";
            string timeStamp = DateTime.Now.ToString();

            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }
            if (!File.Exists(filesPath))
            {
                File.Create(filesPath).Close();
            }

            using (StreamWriter sw = new StreamWriter(filesPath))
            {
                Console.WriteLine("Please enter two numbers:");
                Console.WriteLine("First Number:");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Second Number:");
                int num2 = Convert.ToInt32(Console.ReadLine());
                Sum(num1, num2);
                Console.WriteLine($"The sum result for {num1} + {num2} is {Sum(num1,num2)} and the date and time is: {timeStamp}!");
                
                for(int i = 0; i <= 2; i++)
                {
                    sw.WriteLine($"First number: {num1}");
                    sw.WriteLine($"Second number: {num2}");
                    sw.WriteLine($"The sum result for {num1} + {num2} is {Sum(num1, num2)} on the clock {timeStamp}!");
                }
            }
        }
        public static int Sum(int num1, int num2)
        {
            int result = num1 + num2;
            return result;

        }
    }
}