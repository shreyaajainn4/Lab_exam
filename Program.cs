namespace lab_assement
{
    internal class Program
    {
        static void Main(string[] args)

        {
            string itemName = "";
            double itemPrice = 0;
            double totalPrice = 0;
            int itemQuantity = 0;
            double totalAmount = 0;
            int count = 0;
            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();
            Console.WriteLine("Number of items:");
            int n = Int32.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter item name:");
                itemName = Console.ReadLine();
                Console.WriteLine("Enter item price:");
                itemPrice = Double.Parse(Console.ReadLine());
                Console.WriteLine("Enter item quantity:");
                itemQuantity = Int32.Parse(Console.ReadLine());
                totalPrice = itemPrice * itemQuantity;
                Console.WriteLine($"Item {count}: {itemName}, Price: {itemPrice}, Quantity: {itemQuantity}, Total: {totalPrice}");
                count++;
                totalAmount += totalPrice;
            }
            Console.WriteLine($"Total Amount before discount: {totalAmount}");
            Console.WriteLine("Seasonal Discount 10%: 1");
            Console.WriteLine("Volume Discount 15%: 2");
            Console.WriteLine("Coupon Discount 20%: 3");
            Console.WriteLine("Type of discount:");
            int discount = Int32.Parse(Console.ReadLine());

            //for (int i = 0; i < n; i++) {
            //    totalAmount += itemPrice * itemQuantity;
            //}
            switch (discount)
            {
                case 1:
                    totalAmount *= 0.9;
                    break;
                case 2:
                    totalAmount *= 0.85;
                    break;
                case 3:
                    totalAmount *= 0.80;
                    break;
                default:
                    Console.WriteLine("Invalid discount type.");
                    break;
            }
            Console.WriteLine("--------------------------------------**-----------------------------------");
            Console.WriteLine($"bill Id:{count}");
            Console.WriteLine($"bill To:{name}");
            Console.WriteLine($"Total Amount Bill: {totalAmount}");
        }
    }
}
