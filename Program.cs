// Given a positive integer, write a method that returns multiplication of all digits in the number.
namespace Program{
    class DigitsTask{
        public static void Main(string [] args){
            Console.Clear();
            static int DigitsMultiplication(int number){
                
                return  number>10 ? number % 10 * DigitsMultiplication (number/10) : number % 10;
            }
        Console.WriteLine (DigitsMultiplication(456));// → 120
        Console.WriteLine (DigitsMultiplication(1));// → 6
        }
    }
}