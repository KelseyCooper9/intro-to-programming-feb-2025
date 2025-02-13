using Banking.Domain;
namespace Banking.Tests.Accounts;
public class MakingWithdrawals
{

    [Theory]
    [InlineData(42.23)]
    [InlineData(3.23)] //do these until your confident it works the way it works
    public void MakingWithdrawalsDecreasesTheBalance(decimal amountTowithdraw)
    {
        var account = new Account();
        var openingBalance = account.GetBalance();
        var amountToWithdraw = 42.23M;
        account.Withdraw(amountToWithdraw);
        Assert.Equal(openingBalance - amountToWithdraw,
            account.GetBalance());  
    }

    [Fact]
    public void CanWithdrawFullBalance()
    {
        var account = new Account();
        account.Withdraw(account.GetBalance());
        Assert.Equal(0, account.GetBalance());  
    }


    [Fact]
    public void WhenOverdraftBalanceIsNotReducedNotAllowed()
    {
        var account = new Account();    
        var openingBalance = account.GetBalance();
        var amountThatRepresentsMoreThanTheCurrentBalance = openingBalance + .01M;
        try
        {
            account.Withdraw(amountThatRepresentsMoreThanTheCurrentBalance);
        } catch (AccountTransactionException) { }
        Assert.Equal(openingBalance, account.GetBalance());
    }

    [Fact]
    public void WhenOverdraftMethodThrows()  //if a method throws an exception it has to be part of the method declaration and throws it
    {
        var account = new Account();
        var openingBalance = account.GetBalance();
        var amountThatRepresentsMoreThanTheCurrentBalance = openingBalance + .01M;
        //account.Withdraw(amountThatRepresentsMoreThanTheCurrentBalance);
        //var exceptionThrow = false;
        //try
        //{
        //    account.Withdraw(amountThatRepresentsMoreThanTheCurrentBalance);
        //}
        //catch (AccountOverdraftException)
        //{
        //    exceptionThrow = true;
        //}
        //Assert.True(exceptionThrow);

        Assert.Throws<AccountOverdraftException>(() => account.Withdraw(amountThatRepresentsMoreThanTheCurrentBalance));
    }
}
