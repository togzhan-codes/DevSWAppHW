using System;
using System.Collections.Generic;
using System.Linq;

namespace RestarauntManagement
{
    public class Reservation
    {
        static Dictionary<int, dynamic> dictRes = new Dictionary<int, dynamic>();
        public bool availableTables(DateTime inpDate)
        {
            //DEFAULT VALUES ALREADY EXISTING IN THE DICTIONARY
            DateTime dt1 = new DateTime(2020, 12, 20, 19, 30, 00);
            DateTime dt2 = new DateTime(2020, 12, 20, 18, 00, 00);
            DateTime dt3 = new DateTime(2020, 12, 22, 21, 00, 00);
            dictRes[1] = new { s1 = "Table1", s2 = dt1, s3 = "Aidana", s4 = 4 };
            dictRes[2] = new { s1 = "Table2", s2 = dt2, s3 = "Eldar", s4 = 2 };
            dictRes[3] = new { s1 = "Table3", s2 = dt1, s3 = "Ben", s4 = 1 };
            dictRes[4] = new { s1 = "Table4", s2 = dt1, s3 = "Madina", s4 = 3 };
            dictRes[5] = new { s1 = "Table5", s2 = dt2, s3 = "Dana", s4 = 4 };
            dictRes[6] = new { s1 = "Table3", s2 = dt3, s3 = "Eldar", s4 = 2 };

            var Tables = new List<string>()
        {"Table1","Table2","Table3","Table4","Table5"};
            //EACH ELEMENT FROM THE DICTIONARY WILL BE COMPARED WITH THE inputted Date
            foreach (var item in dictRes.Keys)
            {
                //the date and time value of each key in dictionary is taken
                var value = dictRes[item].s2;
                if (DateTime.Compare(inpDate.Date, value.Date) == 0)//if the dates are the same
                {
                    int diff = Math.Abs(inpDate.Hour - value.Hour);//we want to find time difference of reservation
                    if (diff < 3) { Tables.Remove(dictRes[item].s1); }//if the time difference is less than 3 hours, then this table is excluded from the available tables list
                }
            }
            if (Tables.Count == 0)
            { //if all table were excluded the list will have 0 count
                Console.WriteLine("Unfortunately, we have no free tables for this time");
                return false;
            }
            else
            {//if there is available tables they will be listed here 
                Console.WriteLine("\nThe following tables are available:");
                Tables.ForEach(i => Console.WriteLine("{0}\t", i));
                return true;
            }
        }
        public void makeReservation(string tN, DateTime inDt, string n, int gN)
        {
            int lastKey = dictRes.Keys.Max();
            dictRes[lastKey + 1] = new { s1 = tN, s2 = inDt, s3 = n, s4 = gN };
            Console.WriteLine($"\n{dictRes[lastKey + 1].s3}, you reserved {dictRes[lastKey + 1].s1} for {dictRes[lastKey + 1].s4} guests on {dictRes[lastKey + 1].s2}");
        }
    }
}
