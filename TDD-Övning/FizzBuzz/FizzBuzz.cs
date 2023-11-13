namespace FizzBuzz
{
    public class Kalkylator
    {
        public static string FizzBuzzKalkyl(int nummer)
        {
            if (nummer % 3 == 0 && nummer % 5 == 0) return "FIZZBUZZ";
            if (nummer % 3 == 0) return "FIZZ";
            if (nummer % 5 == 0) return "BUZZ";
         
          
            return nummer.ToString();

           
        }

        public static void FizzBuzzOutput(int nummer)
        {
            string result = FizzBuzzKalkyl(nummer);
            Console.WriteLine(result);
          
        }
    }
}