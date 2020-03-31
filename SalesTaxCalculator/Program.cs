using static System.Console;

namespace SalesTaxCalculator
{
    class Program
    {   
        static decimal calCulateTax(decimal amount, string regionCode)
        {
            decimal rate = 0.0M;

            switch (regionCode)
            {
                case "CH":
                    rate = 0.08M;
                    break;
                case "CA":
                    rate = 0.0825M;
                    break;
                case "DK":
                case "NO":
                    rate = 0.25M;
                    break;
                case "GB":
                case "FR":
                    rate = 0.2M;
                    break;
                case "HU":
                    rate = 0.27M;
                    break;
                case "AR":
                case "OR":
                case "MT":
                    rate = 0.0M;
                    break;
                case "ND":
                case "WI":
                case "ME":
                case "VA":
                    rate = 0.05M;
                    break;
                default:
                    rate = 0.06M;
                    break;
            }

            return rate * amount;
        }

        static void runCalculation()
        {
            WriteLine("Enter Purcahse Amount: ");
            string amount = ReadLine();

            WriteLine("Enter Your two letter State Code");
            string stateCode = ReadLine();

            if(decimal.TryParse(amount, out decimal decAmount))
            {
                decimal taxtoPay = calCulateTax(decAmount, stateCode);
                WriteLine($"You must have to pay {taxtoPay}");
            }
            else
            {
                WriteLine("Invalid Amount");
            }
        }

        static void Main(string[] args)
        {
            runCalculation();
        }
    }
}
