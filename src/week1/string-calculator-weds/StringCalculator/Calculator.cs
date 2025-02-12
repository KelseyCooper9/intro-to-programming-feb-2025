
public class Calculator
{
    public int Add(string number)
    {
        if (number == "")
        {
            return 0;
        }
        else
        {

            string[] separate = number.Split(',');
            var listOfInts = number.Split(',').Select(Int32.Parse).ToList();
            int sum = 0;
            foreach (int listofInt in listOfInts)
            {
                sum += listofInt;
            }
            return sum;
        }
        //int firstStringToNumber =Convert.ToInt32(separate[0]);
        //int secondStringToNumber =Convert.ToInt32(separate[1]);
        //return firstStringToNumber + secondStringToNumber;
        //int stringToNumber = Convert.ToInt32(number);

    }
}
