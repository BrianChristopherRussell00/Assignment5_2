namespace Assignment5_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
               Console.WriteLine("Enter a string: ");//5.1
              string s = Console.ReadLine();
              Console.WriteLine($"The length of {LastWord.checkLength(s)} is {LastWord.LengthOfLastWord(s)}");
            //
            int num = 1;
             Recursion.FirstTen(num);         // 5.2     
            //
             Console.Write(" How many numbers to print : ");//5.3
                int ctr = Convert.ToInt32(Console.ReadLine()); 
            //
          NaturalNumberRec.printNatural(ctr, 1);
              Console.Write("\n\n");
             
            Console.WriteLine("Enter your palindrome");

            Console.WriteLine(Palindrome.CheckIfPalindrome("HANNAH"));           //5.4
        }
    }
}
