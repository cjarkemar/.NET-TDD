namespace FizzBuzz
{
    public class Kalkylator
    {
        public static string FizzBuzzKalkyl(int nummer)
        {
            if (nummer % 3 == 0) return "FIZZ";
            if (nummer % 5 == 0) return "BUZZ";
            if (nummer % 3 == 0 && nummer % 5 == 0) return "FIZZBUZZ";
          
            return nummer.ToString();

           
        }
    }
}