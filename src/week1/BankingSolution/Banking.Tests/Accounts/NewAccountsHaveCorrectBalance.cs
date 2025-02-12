
using Banking.Domain;

namespace Banking.Tests.Accounts;
public class NewAccountsHaveCorrectBalance
{
    [Fact]
    public void BalanceIscorrect()
    {
        var correctOpeningBalance = 5000M;
        //"Write the Code you wish you had"- More Corey Haines Wisdom
        var myAccount = new Account();  //ctrl key period
        var yourAccount = new Account();

        var myBalance = myAccount.GetBalance();
        decimal yourBalance = yourAccount.GetBalance();

        Assert.Equal(correctOpeningBalance, myBalance);
        Assert.Equal(correctOpeningBalance, yourBalance);
        //make sure it fails on an assert initially
    }
}