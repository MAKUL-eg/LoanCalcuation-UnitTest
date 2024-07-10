namespace LoanCalcuationUnitTest
{
    public class Program
    {
        static void Main(string[] args)
        {
            int choice;
            do
            {
                Console.WriteLine("----------MENU_____________");
                Console.WriteLine("1- Calculate annual interest");
                Console.WriteLine("2- Calculate amount to pay per month");
                Console.WriteLine("3- Exit");
                Console.WriteLine("Enter your choice");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:break;
                    case 2:break;
                    case 3:return;
                    default:
                        Console.WriteLine("Invlaid choice");
                        break;
                }

            } while (true);
        }
    }
}
