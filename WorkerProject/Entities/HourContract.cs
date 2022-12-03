
using System.Globalization;

namespace WorkerProject.Entities
{
    class HourContract
    {
        public double ValuePerHour { get; set; }
        public int Hours { get; set; }
        public DateTime Date { get; set; }

        public HourContract()
        {
        }

        public HourContract(DateTime date,  int hours, double valuePerHour)
        {
            Date = date;
            Hours = hours;
            ValuePerHour = valuePerHour;
        }
        override
        public string ToString()
        {
            return " Date: " + Date +
                "\n Hour (s) " + Hours +
                "\n Value per hour: $ " + ValuePerHour.ToString("F2", CultureInfo.InvariantCulture);
        }
        public double TotalValue()
        {
            return Hours * ValuePerHour;
        }
       
    }
}
