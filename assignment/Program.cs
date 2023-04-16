using System;

namespace MyApp // Note: actual namespace depends on the project name.
{

   public class Program
    {
        public static int GetRangedInput(int min, int max)
        {
            Random random = new Random();
            if (min < 1 || max > 1000)
                throw new ArgumentOutOfRangeException("min must be greater than 1", " max must be less than 1000");
            return random.Next(min, max);
         

        }
        public static bool ValidateRangedInput(int min, int max, int value)
        {
            if (value < min && value > max) { return false; }
            return true;
        }
        static void Main(string[] args)
        {
          
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int myrandomnuber = GetRangedInput(num1, num2);
            if(!ValidateRangedInput(num1, num2, myrandomnuber))
                return; 
            bool isdone = false;
          

            while (!isdone)
            {

                int guess = Convert.ToInt32(Console.ReadLine());
                if(guess == myrandomnuber)
                {
                    isdone = true;
                    Console.WriteLine("U have found the answer");
                }
                    
            }


        }
    }
    


}



