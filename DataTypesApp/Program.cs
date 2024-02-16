namespace DataTypesApp
{
    internal class DataTypesProgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the pieces of apple: ");
            int Apples = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the price of " + Apples + " apple(s): ");
            double price = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("The total price of " + Apples + " apples(s) is " + price );

            int c_price = (int)price;
            Console.WriteLine("The value of original price is " + price);
            Console.WriteLine("The value of converted price is " + c_price);



        }
    }
}