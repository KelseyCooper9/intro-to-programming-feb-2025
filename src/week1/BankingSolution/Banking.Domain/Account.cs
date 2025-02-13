namespace Banking.Domain;


public class Account
{
    private decimal _currentBalance = 5000;

    // Queries (methods where we ask for stuff)
    public decimal GetBalance()
    {
        return _currentBalance;
    }
    public virtual void Deposit(decimal amountToDeposit)
    {
        CheckTransactionAmount(amountToDeposit);
        _currentBalance += amountToDeposit;
    }

    // Commands - telling our account to do some work.
    public void Withdraw(decimal amountToWithdraw)
    {
        CheckTransactionAmount(amountToWithdraw);
        if (_currentBalance >= amountToWithdraw)
        {
            _currentBalance -= amountToWithdraw;
        }
        else
        {
            throw new AccountOverdraftException();
        }

    }
    //private methods should only support public methods- do not test private methods
    // Helpers, etc. extracted from the above.
    private void CheckTransactionAmount(decimal amount)
    {
        if (amount < 0)
        {
            throw new AccountNegativeTransactionAmountException();
        }
    }
}