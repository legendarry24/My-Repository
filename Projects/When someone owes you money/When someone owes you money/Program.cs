using System;

namespace When_someone_owes_you_money
{
    class Program
    {
        static void Main(string[] args)
        {
            var initialDate = new DateTime(2016, 12, 07);
            int sum = 50, percentage = 10;
            // you can change the values above to use your own data
            while (true)
            {
                Console.Write("Do you wish use loaded data? (yes/no) ");
                string answer = Console.ReadLine();
                if (answer == "no")   // if you answer "no", you'll have to write another data
                {
                    try
                    {
                        Console.Write("Enter the initial date (yyyy, mm, dd): ");
                        initialDate = DateTime.Parse(Console.ReadLine());
                        Console.Write("Enter the sum: ");
                        sum = int.Parse(Console.ReadLine());
                        Console.Write("Enter the percentage: ");
                        percentage = int.Parse(Console.ReadLine());
                        break;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    //catch (FormatException)
                    //{
                    //    Console.WriteLine("Enter the correct value!");
                    //}
                }
                else if (answer != "yes")
                    Console.WriteLine("Please, enter the correct value!");
                else break;     // if we answered "yes"
            }
            Console.WriteLine("Initial date: " + initialDate.ToLongDateString());
            Console.WriteLine("Today:        " + DateTime.Today.ToLongDateString());
            TimeSpan difference = DateTime.Today - initialDate;
            int days = int.Parse(difference.ToString("%d"));
            Console.WriteLine(days + " days later");
            Console.WriteLine("Initial sum = " + sum + " euro, " +
                              "percentage - " + percentage + " euros per month");
            if (days >= 30)
            {
                while (days >= 30)
                {
                    sum += percentage;
                    days -= 30;
                }
            }
            Console.WriteLine("Final sum   = " + sum + " euro");
            Console.ReadKey();
        }
    }
}