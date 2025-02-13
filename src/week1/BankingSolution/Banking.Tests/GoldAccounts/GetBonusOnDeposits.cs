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

        //given- arrange- establishing the context for this test
        var account = new Account();
        var openingBalance = account.GetBalance();
        var amountToDeposit = 100M;
        var expectedBonus = 20M;
        var expectedNewBalance = openingBalance + amountToDeposit + expectedBonus;
        //when - act
        account.Deposit(amountToDeposit);
        //then- assert
        Assert.Equal(expectedNewBalance, account.GetBalance());

    }
}
