using System;

namespace Badetidssystemet
{
    class Program
    {
        static void Main(string[] args) 
        {
        Console.WriteLine(" opgave nr2");
            Kreds K = new Kreds("1", "A1 ", "PeterBangsvej", 37);
            Kreds K1 = new Kreds("2", " FCB", "Maglegårdsvej", 21);
            Kreds k2 = new Kreds("3", "BBF", "Amager Fælledevej ", 45);

            Console.WriteLine(K);
            Console.WriteLine();
            Console.WriteLine(K1);
            Console.WriteLine();
            Console.WriteLine(k2);


            Console.WriteLine(); Console.WriteLine();
            try
            {
                BadetidsPeriode b1 = new BadetidsPeriode("AFten Bad", DayOfWeek.Monday, new DateTime().AddHours(18).AddMinutes(30), new DateTime().AddHours(20).AddMinutes(30));
                BadetidsPeriode b2 = new BadetidsPeriode("middag ", DayOfWeek.Wednesday, new DateTime().AddHours(12).AddMinutes(10), new DateTime().AddHours(14).AddMinutes(15));
                BadetidsPeriode b3 = new BadetidsPeriode("Morgen bad ", DayOfWeek.Tuesday, new DateTime().AddHours(7).AddMinutes(15), new DateTime().AddHours(9).AddMinutes(15));
                b1.AdderKreds(K);
                b2.AdderKreds(k2);
                b1.AdderKreds(K1);
                b1.SletKredse("2");

                Console.WriteLine(b1);
                Console.WriteLine(b2);
                Console.WriteLine(b3);
                    
                    }

            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            Console.ReadKey();
        }
    }
}
