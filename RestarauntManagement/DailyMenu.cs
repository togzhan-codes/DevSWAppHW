using System;
using System.Collections.Generic;

namespace RestarauntManagement
{
    public class DailyMenu
    {
        public void listDM(DateTime inpDate)
        {
            var dictMenu = new Dictionary<String, dynamic>();
            dictMenu["Monday"] = new { meal = "Homemade Meatloaf", soup = "French Onion soup", salad = "Waldorf Chicken salad" };
            dictMenu["Tuesday"] = new { meal = "Pepperoni Pizza", soup = "Chicken TortilLa soup", salad = "Taco salad" };
            dictMenu["Wednesday"] = new { meal = "Grilled Chicken Pasta", soup = "Mushroom Cream soup", salad = "Caprese salad" };
            dictMenu["Thursday"] = new { meal = "Grilled Salmon", soup = "Thai Lime Prawn soup", salad = "Cobb salad" };
            dictMenu["Friday"] = new { meal = "Mushroom Lasagna", soup = "Italian Wedding soup", salad = "Asian Chicken salad" };
            dictMenu["Saturday"] = new { meal = "Carbonara Pasta", soup = "Chicken Noodle soup", salad = "Spinach salad" };
            dictMenu["Sunday"] = new { meal = "Cheese Ravioli", soup = "Broccoli Cheddar soup", salad = "Ceasar salad" };
            //DAILY MENU IS PRINTED DEPENDING ON THE weekday of the inputted date
            Console.WriteLine($"\nYour reserved day is {inpDate.DayOfWeek} and the Daily Menu for this day is:\nSoup: {dictMenu[inpDate.DayOfWeek.ToString()].soup} \nSalad: {dictMenu[inpDate.DayOfWeek.ToString()].salad} \nMain Meal: {dictMenu[inpDate.DayOfWeek.ToString()].meal}");
        }
    }
}
