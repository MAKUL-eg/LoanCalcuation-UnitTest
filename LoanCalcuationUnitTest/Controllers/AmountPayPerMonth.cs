using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanCalcuationUnitTest.Controller
{
    public class AmountPayPerMonth
    {
        public double CalculateAmountPayPerMonth(int principalAmount, double annualInterestRate, int termYear)
        {
            if (principalAmount < 0)
                throw new ArgumentException("Principal amount cannot be negative.");
            if (annualInterestRate < 0 || annualInterestRate>20)
                throw new ArgumentException("Annual interest rate out of range");
            if (termYear < 0)
                throw new ArgumentException("Term in years cannot be negative.");
            if (termYear >30)
                throw new ArgumentException("Term in years cannot be more than 20years.");
            

            double totalIntrestToPay= annualInterestRate==0?0:principalAmount * (annualInterestRate / 100) * termYear;
            double newAmount=principalAmount+totalIntrestToPay;
            return Math.Round(newAmount / (termYear * 12),2);
        }

    }
}
