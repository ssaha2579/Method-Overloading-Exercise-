namespace MethodOverloading
{
    public class Program
    {
        public  static int Add(int numOne, int numTwo)
        { 
            return numOne + numTwo;
        }

        public static string Add(int numOne, int numTwo, bool isCurrency)
        {
            var sum = numOne + numTwo;

            if (isCurrency && sum > 1)
            {
                return $"{sum} dollars";
            }

            else if (isCurrency && sum == 1)
            { 
                    return $"{sum} dollar"; 
            }
            else
            {
                return sum.ToString();
            }

        }

        public static string Add(string numOne, string numTwo)
        {
            return numOne + numTwo;
        } 

        static void Main(string[] args)
        {
            Console.WriteLine(Add(numOne: 0, numTwo: 0, true));
        }
    }
}
