namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 3;

            while (count > 0)
            {



               
                Console.WriteLine("Marka : ");
                string carBrandName = Console.ReadLine();
                Console.WriteLine("Model : ");
                string carModelName = Console.ReadLine();
                Console.WriteLine("Buraxilis ili : ");
                int carYear = int.Parse(Console.ReadLine());
                Console.WriteLine("Negd qiymeti : ");
                decimal carCashPrice = decimal.Parse(Console.ReadLine());

                Console.WriteLine("");
                Console.WriteLine("##################################");
                Console.WriteLine("");

                Console.WriteLine("Kredit faizi : ");
                decimal carCreditPercent = decimal.Parse(Console.ReadLine());
                int creditTimeRules = 3;
                int PercentForEveryYear = 2;
                Console.WriteLine("Kredit muddeti : ");
                decimal carCreditTime = decimal.Parse(Console.ReadLine());
                decimal carCreditPrice = 0;

                count = count - 1;
            if (carCreditTime >= creditTimeRules)
            {
                carCreditPrice = carCashPrice  + carCashPrice * ((carCreditPercent) + (carCreditTime - creditTimeRules) * PercentForEveryYear) / (100);
                Console.WriteLine("Kredit qiymeti : " + carCreditPrice);
            }
            else
            {
                carCreditPrice = carCashPrice  + carCashPrice * carCreditPercent / 100;
                Console.WriteLine("Kredit qiymeti : " + carCreditPrice);
            }
            }





        }
    }
}