namespace LoanCalcuationUnitTest.Controller
{
    public class InterestCalculator
    {
        public double CalculateTotalIntrest(int principleAmount,double intrest,int loanTermInYears)
        {
                if (principleAmount < 0 || principleAmount> int.MaxValue)
                    throw new ArgumentException("Invalid");
                if (intrest < 0 || intrest > 20)
                    throw new ArgumentException("Invalid");
                if (loanTermInYears < 0 || loanTermInYears > 30)
                    throw new ArgumentException("Invalid");

                return principleAmount * (intrest / 100) * loanTermInYears;
            }
            
                
    }
}

