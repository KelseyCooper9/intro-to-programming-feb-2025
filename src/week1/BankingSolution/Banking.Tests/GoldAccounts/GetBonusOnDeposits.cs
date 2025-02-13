using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banking.Tests.Accounts;
using Banking.Domain;

namespace Banking.Tests.GoldAccounts;
public class GetBonusOnDeposits
{
    [Fact]
    public void GetBonus()
    {
        var account = new Account();
        var openingBalance = account.GetBalance();
        var amountToDeposit = 100M;
        var expectedBonus = 20M;
        var expectedNewBalance = openingBalance + amountToDeposit + expectedBonus;

        account.Deposit(amountToDeposit);

        Assert.Equal(expectedNewBalance, account.GetBalance());

    }
}
