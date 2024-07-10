using LoanCalcuationUnitTest.Controller;


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
               

                try
                {
                    choice = Convert.ToInt32(Console.ReadLine());
                   

                switch (choice)
                {
                    case 1:
                            ReadInputs(out principleAmount, out intrest, out loanTermInYears);
                          InterestCalculator interestCalculator=new InterestCalculator();
                            Console.WriteLine($"Total intrest for the principle amount { principleAmount} is {interestCalculator.CalculateTotalIntrest(principleAmount, intrest, loanTermInYears)}");
                           


                        break;
                    case 2:break;
                    case 3:return;
                    default:
                        Console.WriteLine("Invlaid choice");
                        break;
                }
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid input");
                }

            } while (true);
        }
         

          public static void ReadInputs(out int principleAmount,out double intrest, out int loanTermInYears)
        {
            Console.Write("Enter principle amount: ");
            principleAmount = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter intrest(<20%): ");
            intrest = Convert.ToInt64(Console.ReadLine());

            Console.Write("Enter the term(<30): ");
            loanTermInYears = Convert.ToInt32(Console.ReadLine());
        }
            
   
    }
}
