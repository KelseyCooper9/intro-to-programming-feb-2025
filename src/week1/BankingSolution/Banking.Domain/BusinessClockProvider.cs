namespace Banking.Domain;

public class BusinessClockProvider: IProvideTheBusinessClockForBonusCalculation
{
    public bool WeAreCurrentlyDuringBusinessHours()
    {
        if (DateTimeOffset.Now.DayOfWeek == DayOfWeek.Saturday){
            return true;
        }
        return false;
    }
}