
namespace Banking.Domain;

public class Account //type of thing, an instance of that type of thing//need to instantiate with New ""() keyword
{
    private decimal _currentBalance = 5000; //automatically private by default
    
    public decimal GetBalance()
    {
        return _currentBalance;
    }
    public void Deposit(decimal amountToDeposit)
    {
            _currentBalance += amountToDeposit;
    }

    public void Withdraw(decimal amountToWithdraw)
    {
        if (_currentBalance >= amountToWithdraw)
        {
            _currentBalance -= amountToWithdraw;
        }
        else
        {
            throw new AccountOverdraftException();
        }
    }
}
//ctrl k ctrl d to reformat 
