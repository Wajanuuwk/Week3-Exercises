using System;

namespace WeatherReport
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib mittu kraadi õues on;
            //kui õues on rohkem kui 35 kraadi, programm kuvab "boiling hot";
            //kui õues on vähem kui 30 kuni 35 kraadi, programm kuvab "hot";
            //kui õues on 20 kuni 30 kraadi, programm kivab "nice";
            //kui õues on 10 kuni 200 kraadi, programm kuvab "chilly";
            //kui õues on 0 kuni 10 kraadi, programm kuvab "cold"; 
            //kui õues on alla 10 kraadi, programm kuvab "freezing cold";

            Console.WriteLine("Mitu kraadi õues on?");
            int Temp = Convert.ToInt32(Console.ReadLine());

            if (Temp >= 35)
            {
                Console.WriteLine("Boiling hot.");
            }
            else if (Temp >= 30 && Temp < 35)
            {
                Console.WriteLine("Hot.");
            }
            else if (Temp >= 20 && Temp < 30)
            {
                Console.WriteLine("Nice.");
            }
            else if (Temp >= 10 && Temp < 20)
            {
                Console.WriteLine("Chilly.");
            }
            else if (Temp >= 0 && Temp < 10)
            {
                Console.WriteLine("Cold:");
            }
            else
            {
                Console.WriteLine("Freezing cold.");
            }
        }
    }
}
