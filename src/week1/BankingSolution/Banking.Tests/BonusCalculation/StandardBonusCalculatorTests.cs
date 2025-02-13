

using Banking.Domain;

namespace Banking.Tests.BonusCalculation;
public class StandardBonusCalculatorTests
{
   
    [Theory]
    [InlineData(5, 100, 0)]
    [InlineData(4999.99, 200, 0)]
    [InlineData(0, 1000, 0)]

    public void BonusesBelowThresholdGetnoBonus(decimal balance, decimal depositAmount, decimal expectedBonus)
    {
        var bonusCalculator = new StandardBonusCalculator();

        decimal bonus = bonusCalculator.CalculateBonusForDeposit(balance, depositAmount);

        Assert.Equal(expectedBonus, bonus);

    }
}