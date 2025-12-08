using System;

class SmartBillingSystem
{
    static void Main()
    {
        Console.Write("Enter number of consumers: ");
        int n = int.Parse(Console.ReadLine());

        double totalRevenue = 0;
        double highestBill = 0;
        string highestBillConsumer = "";

        int domesticCount = 0;
        int commercialCount = 0;

        Console.WriteLine("\n--- Consumer-wise Bill Details ---");

        for (int i = 0; i < n; i++)
        {
            Console.Write("\nEnter Consumer ID: ");
            string consumerID = Console.ReadLine();

            Console.Write("Enter Units Consumed: ");
            int units = int.Parse(Console.ReadLine());

            Console.Write("Enter Connection Type (1 = Domestic, 2 = Commercial): ");
            int type = int.Parse(Console.ReadLine());

            string typeName = (type == 1) ? "Domestic" : "Commercial";
            if (type == 1) domesticCount++; else commercialCount++;

            double baseCharge = 0;

            if (type == 1) 
            {
                if (units <= 100)
                    baseCharge = units * 1.50;
                else if (units <= 300)
                    baseCharge = (100 * 1.50) + ((units - 100) * 2.50);
                else
                    baseCharge = (100 * 1.50) + (200 * 2.50) + ((units - 300) * 4.00);
            }
            else 
            {
                if (units <= 200)
                    baseCharge = units * 5.00;
                else if (units <= 500)
                    baseCharge = (200 * 5.00) + ((units - 200) * 6.50);
                else
                    baseCharge = (200 * 5.00) + (300 * 6.50) + ((units - 500) * 8.00);
            }

            double surcharge = baseCharge * 0.03;
            double penalty = (units > 500) ? 200 : 0;

            double total = baseCharge + surcharge + penalty;

            double discount = (total > 2000) ? total * 0.05 : 0;

            double finalBill = total - discount;
            totalRevenue += finalBill;

            if (finalBill > highestBill)
            {
                highestBill = finalBill;
                highestBillConsumer = consumerID;
            }

            Console.WriteLine($"{consumerID} {typeName} Units:{units} Base:{baseCharge:F2} " +
                              $"Surcharge:{surcharge:F2} Penalty:{penalty:F2} " +
                              $"Discount:{discount:F2} Final:{finalBill:F2}");
        }

        Console.WriteLine("\n--- Summary ---");
        Console.WriteLine($"Total Consumers: {n}");
        Console.WriteLine($"Total Revenue: ₹{totalRevenue:F2}");
        Console.WriteLine($"Highest Bill: {highestBillConsumer} ₹{highestBill:F2}");
        Console.WriteLine($"Domestic: {domesticCount} Commercial: {commercialCount}");
    }
}
