using System;

namespace Week3Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada PIN koodi
            //programm võrdleb sisestatud PIN-koodi arvuga 1234
            //Kui sisestatud PIN-kood on 1234
            //programm kuvab konsoolis "Tere tulemast"
            //kui sisustatud PIN on vale, programm kuvab konsoolis
            //"Vale PIN. Proovi uuesti."

            Console.WriteLine("Sisesta PIN-kood");
            int pin = Convert.ToInt32(Console.ReadLine());

            if (pin == 1234)
            {
                Console.WriteLine("Tere Tulemast");
                Console.WriteLine("Sisestatud PIN-kood on õige");
            }
            else
            {
                Console.WriteLine("Vale PIN. Proovi uuesti.");
            }
            
        }
    }
}
