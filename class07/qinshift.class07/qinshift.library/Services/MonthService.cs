using qinshift.library.Enums;

namespace qinshift.library.Services
{
    public class MonthService
    {
        public Months GetMonthOutOfNumber(int number)
        {
            return (Months)number;
        }

        public int GetNumberOutOfEnumValue(Months month)
        {
            return (int)month;
        }
    }
}
