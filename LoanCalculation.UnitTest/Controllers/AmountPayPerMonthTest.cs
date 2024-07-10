using LoanCalcuationUnitTest.Controller;

namespace LoanCalculation.UnitTest.Controllers
{
    public class AmountPayPerMonthTest
    {
        [Theory]
        [InlineData(1000, 0, 1, 83.33)]
        [InlineData(10000, 5, 20, 83.33)]
        [InlineData(1000000,12.7,2,52250)]
        public void TestAmountPayPerMonth_validValues(int principalAmount, double annualInterestRate, int termYear, double expectedOutput)
        {
            AmountPayPerMonth amountPayPerMonth = new();
            double amount = amountPayPerMonth.CalculateAmountPayPerMonth(principalAmount, annualInterestRate, termYear);
            Assert.Equal(expectedOutput, amount);
        }

        [Fact]
        public void TestAmountPayPerMonth_validValuesFact()
        {
            //Arrange
            int principalAmount = 1000000;
            double annualInterestRate = 11.5;
            int termYear = 7;
            double expectedOutput = 21488.1;
            AmountPayPerMonth amountPayPerMonth = new();

            //Act
            double amount = amountPayPerMonth.CalculateAmountPayPerMonth(principalAmount, annualInterestRate, termYear);

            //Assert
            Assert.Equal(expectedOutput, amount);
        }


        [Theory]
        [InlineData(-1000, 0, 1)]
        [InlineData(1000, -1, 1)]
        [InlineData(1000, 1, -1)]
        [InlineData(1000, 101, 1)]
        [InlineData(1000, 5, 50)]
        public void TestAmountPayPerMonth_exceptions(int principalAmount, double annualInterestRate, int termYear)
        {
            AmountPayPerMonth amountPayPerMonth = new();
            Assert.Throws<ArgumentException>(() => amountPayPerMonth.CalculateAmountPayPerMonth(principalAmount, annualInterestRate, termYear));
        }
    }
}
