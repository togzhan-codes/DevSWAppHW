using System;
namespace RestarauntManagement
{
    class RestarauntSystem
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello and Welcome to Restaurant 'Central Perk'!");
            Change:
            Console.Write("\nEnter a date and time of the reservation you want (e.g. 12/18/2020 8:00 PM): ");
            DateTime inputtedDate = DateTime.Parse(Console.ReadLine());
            Reservation obj = new Reservation();
            if (obj.availableTables(inputtedDate))
            {
                Console.WriteLine("Would you like to continue the reservation?  (yes/no)");
                if (Console.ReadLine() == "yes")
                {
                    Console.WriteLine("\nChoose table number (e.g. Table1): ");
                    var tableNum = Console.ReadLine();
                    Console.WriteLine("\nProvide the Name for Reservation: ");
                    var name = Console.ReadLine();
                    Console.WriteLine("\nChoose number of guests (max 6)");
                    int guestNum = int.Parse(Console.ReadLine());
                    obj.makeReservation(tableNum, inputtedDate, name, guestNum);
                    Console.WriteLine("Would you like to see the Daily Menu for the day you reserved?  (yes/no)");
                    if (Console.ReadLine() == "yes")
                    {
                        DailyMenu obj1 = new DailyMenu();
                        obj1.listDM(inputtedDate);
                        Console.WriteLine("Thank you for choosing 'Central Perk'! Good Bye!");
                    }
                    else
                    {
                        Console.WriteLine($"Ok, see you on the {inputtedDate.ToString("MM/dd/yyyy")} at {inputtedDate.TimeOfDay}");
                    }
                }
                else
                {
                    Console.WriteLine("Good Bye!");
                }
            }
            else
            {
                Console.WriteLine("Would you like to change date? (yes/no)");
                if (Console.ReadLine() == "yes")
                {
                    goto Change;//redirects to the stage of inputing date of reservation
                }
                else
                {
                    Console.WriteLine("Good Bye!");
                }
            }
        }
    }
}
