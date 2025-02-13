namespace Banking.Domain;


public class Account
{
    private decimal _currentBalance = 5000;
    public bool IsGoldAccount = false;

    // Queries (methods where we ask for stuff)
    public decimal GetBalance()
    {
        return _currentBalance;
    }
    public void Deposit(decimal amountToDeposit, bool isGoldAccount = false)
    {
        var bonus = 0M;
        if (isGoldAccount)
        {
            bonus = amountToDeposit + 20M;
        }
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