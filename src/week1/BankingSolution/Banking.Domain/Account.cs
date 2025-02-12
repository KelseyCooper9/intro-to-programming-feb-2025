
namespace Banking.Domain;

public class Account //type of thing, an instance of that type of thing//need to instantiate with New ""() keyword
{
    private decimal _openingBalance = 5000; //automatically private by default
    
    public decimal GetBalance()
    {
        return _openingBalance;
    }
    public void Deposit(decimal amountToDeposit)
    {
        _openingBalance += amountToDeposit;
    }

    public void Withdraw(decimal amountToWithdraw)
    {
        _openingBalance -= amountToWithdraw;
    }
}

//ctrl k ctrl d to reformat 
