using LoanCalcuationUnitTest.Controller;
using Xunit.Abstractions;

namespace LoanCalculation.UnitTest.Controller
{
   
    public class TotalIntrestTesting
    {
        [Theory]
        [InlineData(1000,2,1,20)]// Normal Case
        [InlineData(1000, 0, 1, 0)]// When intrest is zero

        public void Intrest(int principleAmount, double intrest, int loanTermInYears,int Expected)
        {
            InterestCalculator interestCalculator = new InterestCalculator();
                Assert.Equal(Expected,interestCalculator.CalculateTotalIntrest(principleAmount,intrest,loanTermInYears));
        }

        [Theory]
        //   For Negative values
        [InlineData(-1000, 2, 1)]
        [InlineData(1000, -2, 1)]
        [InlineData(1000, 2,-1)]
        // For out of bound values
        [InlineData(1000, 30, 1)]
        [InlineData(1000, 2, 60)]
        
        public void Intrest_Exception(int  principleAmount, double intrest, int loanTermInYears)
        {
            InterestCalculator interestCalculator = new InterestCalculator();
            Assert.Throws<ArgumentException>(() =>
            
                interestCalculator.CalculateTotalIntrest(principleAmount, intrest, loanTermInYears)
            );
        }
       [Fact]
        public void IntrestFactMethod()
        {
            // Arrange
            int principleAmount=1000;
            double intrest=2;
            int loanTermInYears=1;
            int Expected=20;

            // Act
            InterestCalculator interestCalculator = new InterestCalculator();
            double result = interestCalculator.CalculateTotalIntrest(principleAmount, intrest, loanTermInYears);

            // Assert
            Assert.Equal(Expected, result);
        }

        [Fact]
        public void IntrestFactMethodForException()
        {
            // Arrange
            int principleAmount = -1000;
            double intrest = 2;
            int loanTermInYears = 1;

            //Act and Assert
            InterestCalculator interestCalculator = new InterestCalculator();
            Assert.Throws<ArgumentException>(() =>

                interestCalculator.CalculateTotalIntrest(principleAmount, intrest, loanTermInYears)
            );


        }
    }
}
