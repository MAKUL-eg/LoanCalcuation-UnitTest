namespace LoanCalcuationUnitTest
{
    public class Program
    {
        public static void Main()
        {
            int choice;
            int principleAmount;
            double intrest;
            int loanTermInYears;
            do
            {
                Console.WriteLine("----------MENU_____________");
                Console.WriteLine("1- Calculate interest");
                Console.WriteLine("2- Calculate amount to pay per month (simple intrest)");
                Console.WriteLine("3- Exit");
                Console.WriteLine("Enter your choice");
                choice = Convert.ToInt32(Console.ReadLine());

                try
                {
                    Console.Write("Enter principle amount: ");
                    principleAmount = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Enter intrest: ");
                    intrest= Convert.ToInt64(Console.ReadLine());
                    
                    Console.Write("Enter the term: ");
                    loanTermInYears = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid input");
                }

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
