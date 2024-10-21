using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace FirsConsol_1
{
    internal class Program
    {

        enum enWeekDays
        {
            Monday,     // 0
            Tuesday,    // 1
            Wednesday,  // 2
            Thursday,   // 3
            Friday,     // 4
            Saturday,   // 5
            Sunday      // 6
        }

        //if you set a value , it will auto number everything after it.
        enum enCategories
        {
            Electronics,    // 0
            Food,           // 1
            Automotive = 6, // 6
            Arts,           // 7
            BeautyCare,     // 8
            Fashion         // 9
        }


        //Enum can have any numarical data type byte, sbyte, short, ushort, int, uint, long, or ulong
        //but not string

        enum enCategories2 : byte
        {
            Electronics = 1,
            Food = 5,
            Automotive = 6,
            Arts = 10,
            BeautyCare = 11,
            Fashion = 15
        }



        struct stStudent
        {
            public string FirstName;
            public string LastName;
        }

        static void Main(string[] args)
        {
            //string a, b;
            //short c = 10;
            //System.Int32 g = 50;
            //sbyte d = 127;
            //byte p = 255;

            //System.Console.WriteLine("Hello");
            //System.Console.WriteLine(c);
            //System.Console.WriteLine(g);
            // a = System.Console.ReadLine();
            // b = System.Console.ReadLine();
            // System.Console.WriteLine("First Name: {0}\nLast Name: {1}", a, b);

            //System.Console.WriteLine("\nByte");
            //System.Console.WriteLine("Min: {0} Max: {1}", Byte.MinValue, Byte.MaxValue);


            ////get default value using default(type)
            //int i = default(int); // 0
            //float f = default(float);// 0
            //decimal d = default(decimal);// 0
            //bool b = default(bool);// false
            //char c = default(char);// '\0'

            //// C# 7.1 onwards
            ////get default value using default
            //int i2 = default; // 0
            //float f2 = default;// 0
            //decimal d2 = default;// 0
            //bool b2 = default;// false
            //char c2 = default;// '\0'

            //System.Console.WriteLine(i);
            //System.Console.WriteLine(f);
            //System.Console.WriteLine(d);
            //System.Console.WriteLine(b);
            //System.Console.WriteLine(c);
            //System.Console.WriteLine(i2);
            //System.Console.WriteLine(f2);
            //System.Console.WriteLine(d2);
            //System.Console.WriteLine(b2);
            //System.Console.WriteLine(c2);



            //enWeekDays WeekDays;

            //WeekDays = enWeekDays.Friday;
            //Console.WriteLine(WeekDays);

            //enCategories2 WeekDays2;

            //WeekDays2 = enCategories2.Arts;
            //Console.WriteLine(WeekDays2);

            //Nullable<int> i = null;
            //Console.WriteLine(i);






            ////you dont specify any type here , automatically will be specified
            //var student = new { Id = 20, FirstName = "Mohammed", LastName = "Abu-Hadhoud" };

            //Console.WriteLine("\nExample1:\n");
            //Console.WriteLine(student.Id); //output: 20
            //Console.WriteLine(student.FirstName); //output: Mohammed
            //Console.WriteLine(student.LastName); //output: Abu-Hadhoud

            ////You can print like this:
            //Console.WriteLine(student);


            ////anonymous types are read-only
            ////you cannot change the values of properties as they are read-only.

            //// student.Id = 2;//Error: cannot chage value
            //// student.FirstName = "Ali";//Error: cannot chage value


            ////An anonymous type's property can include another anonymous type.
            //var student2 = new
            //{
            //    Id = 20,
            //    FirstName = "Mohammed",
            //    LastName = "Abu-Hadhoud",
            //    Address = new { Id = 1, City = "Amman", Country = "Jordan" }
            //};

            //Console.WriteLine("\nExample2:\n");
            //Console.WriteLine(student2.Id);
            //Console.WriteLine(student2.FirstName);
            //Console.WriteLine(student2.LastName);

            //Console.WriteLine(student2.Address.Id);
            //Console.WriteLine(student2.Address.City);
            //Console.WriteLine(student2.Address.Country);
            //Console.WriteLine(student2.Address);





            //A struct object can be created with or without the new operator,
            //same as primitive type variables.

            //stStudent Student;
            //stStudent Student2 = new stStudent();


            //Student.FirstName = "Mohammed";
            //Student.LastName = "Abu-Hadhoud";


            //Console.WriteLine(Student.FirstName);
            //Console.WriteLine(Student.LastName);


            //Student2.FirstName = "Ali";
            //Student2.LastName = "Ahmed";


            //Console.WriteLine(Student2.FirstName);
            //Console.WriteLine(Student2.LastName);




            //dynamic MyDynamicVar = 100;
            //Console.WriteLine("Value: {0}, Type: {1}", MyDynamicVar, MyDynamicVar.GetType());

            //MyDynamicVar = "Hello World!!";
            //Console.WriteLine("Value: {0}, Type: {1}", MyDynamicVar, MyDynamicVar.GetType());

            //MyDynamicVar = true;
            //Console.WriteLine("Value: {0}, Type: {1}", MyDynamicVar, MyDynamicVar.GetType());

            //MyDynamicVar = DateTime.Now;
            //Console.WriteLine("Value: {0}, Type: {1}", MyDynamicVar, MyDynamicVar.GetType());




            ////assigns default value 01/01/0001 00:00:00
            //DateTime dt1 = new DateTime();

            ////assigns year, month, day
            //DateTime dt2 = new DateTime(2023, 12, 31);

            ////assigns year, month, day, hour, min, seconds
            //DateTime dt3 = new DateTime(2023, 12, 31, 5, 10, 20);

            ////assigns year, month, day, hour, min, seconds, UTC timezone
            //DateTime dt4 = new DateTime(2023, 12, 31, 5, 10, 20, DateTimeKind.Utc);

            //Console.WriteLine(dt1);
            //Console.WriteLine(dt2);
            //Console.WriteLine(dt3);
            //Console.WriteLine(dt4);
            //Console.WriteLine(DateTime.Now);

            //DateTime dt5 = new DateTime();
            //dt5 = DateTime.Now;
            //Console.WriteLine(dt5);


            ////number of 100-nanosecond intervals that have elapsed
            ////since January 1, 0001, at 00:00:00.000 in the Gregorian calendar. 

            //DateTime dt = new DateTime();
            //Console.WriteLine(DateTime.MinValue.Ticks);  //min value of ticks
            //Console.WriteLine(DateTime.MaxValue.Ticks); // max value of ticks




            //DateTime currentDateTime = DateTime.Now;  //returns current date and time
            //DateTime todaysDate = DateTime.Today; // returns today's date
            //DateTime currentDateTimeUTC = DateTime.UtcNow;// returns current UTC date and time
            //DateTime maxDateTimeValue = DateTime.MaxValue; // returns max value of DateTime
            //DateTime minDateTimeValue = DateTime.MinValue; // returns min value of DateTime

            //Console.WriteLine("currentDateTime: " + currentDateTime);
            //Console.WriteLine("Today: " + todaysDate);
            //Console.WriteLine("currentDateTimeUTC: " + currentDateTimeUTC);
            //Console.WriteLine("minDateTimeValue: " + minDateTimeValue);
            //Console.WriteLine("maxDateTimeValue: " + maxDateTimeValue);



            //DateTime dt = new DateTime(2023, 2, 21);

            //// Hours, Minutes, Seconds
            //TimeSpan ts = new TimeSpan(49, 25, 34);
            //Console.WriteLine(ts);
            //Console.WriteLine(ts.Days);
            //Console.WriteLine(ts.Hours);
            //Console.WriteLine(ts.Minutes);
            //Console.WriteLine(ts.Seconds);

            ////this will add time span to the date.
            //DateTime newDate = dt.Add(ts);

            //Console.WriteLine(newDate);



            //DateTime dt1 = new DateTime(2023, 2, 21);
            //DateTime dt2 = new DateTime(2023, 2, 25);
            //TimeSpan result = dt2.Subtract(dt1);

            //Console.WriteLine(result.Days);




            //DateTime dt1 = new DateTime(2015, 12, 20);
            //DateTime dt2 = new DateTime(2016, 12, 31, 5, 10, 20);
            //TimeSpan time = new TimeSpan(10, 5, 25, 50);

            //Console.WriteLine(dt2 + time); // 1/10/2017 10:36:10 AM
            //Console.WriteLine(dt2 - dt1); //377.05:10:20
            //Console.WriteLine(dt1 == dt2); //False
            //Console.WriteLine(dt1 != dt2); //True
            //Console.WriteLine(dt1 > dt2); //False
            //Console.WriteLine(dt1 < dt2); //True
            //Console.WriteLine(dt1 >= dt2); //False
            //Console.WriteLine(dt1 <= dt2);//True


            var str = "6/12/2023";
            DateTime dt;

            var isValidDate = DateTime.TryParse(str, out dt);

            if (isValidDate)
                Console.WriteLine(dt);
            else
                Console.WriteLine($"{str} is not a valid date string");

            //invalid string date
            var str2 = "6/65/2023";
            DateTime dt2;

            var isValidDate2 = DateTime.TryParse(str2, out dt2);

            if (isValidDate2)
                Console.WriteLine(dt2);
            else
                Console.WriteLine($"{str2} is not a valid date string");















            Console.ReadKey();
        }
    }
}
