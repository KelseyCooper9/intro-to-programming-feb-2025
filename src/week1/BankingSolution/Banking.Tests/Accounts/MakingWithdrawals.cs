﻿using Banking.Domain;
namespace Banking.Tests.Accounts;
public class MakingWithdrawals
{

    [Theory]
    [InlineData(42.23)]
    [InlineData(3.23)] //do these until your confident it works the way it works
    [InlineData(5000)] // can take the full balance 
    [InlineData (5000.01)] //overdraft sus?
    public void MakingWithdrawalsDecreasesTheBalance(decimal amountTowithdraw)
    {
        var account = new Account();
        var openingBalance = account.GetBalance();
        var amountToWithdraw = 42.23M;
        account.Withdraw(amountToWithdraw);
        Assert.Equal(openingBalance - amountToWithdraw,
            account.GetBalance());  
    }


    [Fact(Skip = "we'll do this in the morning")]
    public void OverdraftNotAllowed()
    {
        var account = new Account();    
        var openingBalance = account.GetBalance();
        var amountToWithdraw = openingBalance + .01M;
        account.Withdraw(amountToWithdraw);
        Assert.Equal(openingBalance, account.GetBalance());
    }
}
