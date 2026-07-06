namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region solution1
            //Console.WriteLine("Estimate for carpet cleaning service");
            //Console.Write("Number of small carpets:");
            //int small = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Number of large carpets:");
            //int large = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Price per small carpet : $25 \n Price per large carpet : $35");
            //int cost = (small * 25) + (large * 35);
            //Console.WriteLine("Cost: $" + cost);
            //double tax = 0.06 * cost;
            //Console.WriteLine("Tax: $" + tax);
            //Console.WriteLine("Total estimate: $" + (cost + tax));
            //Console.WriteLine("This estimate is valid for 30 days"); 
            #endregion

            #region solution2
            // The second solution using standard numeric format
            Console.WriteLine("Estimate for carpet cleaning service");
            Console.Write("Number of small carpets:");
            int small = Convert.ToInt32(Console.ReadLine());
            Console.Write("Number of large carpets:");
            int large = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Price per small carpet : $25 \n Price per large carpet : $35");
            int cost = (small * 25) + (large * 35);
            Console.WriteLine($"Cost: {cost:C}");
            double tax = 0.06 * cost;
            Console.WriteLine($"Tax: {tax:C}");
            Console.WriteLine($"Total estimate: {cost + tax:C}");
            Console.WriteLine("This estimate is valid for 30 days");
            #endregion
        }
    }
}
