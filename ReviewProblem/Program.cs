namespace ReviewProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Number Swap Problem");
            Console.WriteLine("Enter a number select the method to swap 2 numbers");
            Console.WriteLine("1. Using Addition Subtraction");
            Console.WriteLine("2. Using Multiplication Division");
            int ip = Convert.ToInt32(Console.ReadLine());
            switch (ip)
            {
                case 1:
                    SwapNumber a= new SwapNumber();
                    a.Swap();

                    break;
                case 2: 
                    SwapNumberMethodTwo b = new SwapNumberMethodTwo();
                    
                    break;


            }
        }
    }

}