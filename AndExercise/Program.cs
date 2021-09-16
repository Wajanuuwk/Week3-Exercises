using System;

namespace AndExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //tingimused sisseastumiseks:          
            //miinimum matemaatikas 85 punkti;
            //miinimum keemias 90 punkti;
            //miinimum bioloogias 95 punkti;
            //programm küsib kasutajal sisestada tema
            //eksami punktid ja ostsustab, kas kasutaja
            //saab arstiks õppida

            Console.WriteLine("Sisesta matemaatika eksami tulemus:");
            int math = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("sisesta keemia eksami tulemus:");
            int chemistry = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("sisesta bioloogia eksami tulemus:");
            int biology = Convert.ToInt32(Console.ReadLine());

            if (math >= 85 && chemistry >= 90 && biology >= 95)
            {
                Console.WriteLine("Saad arstiks õppida.");
            }
            else
            {
                Console.WriteLine("Ei saa arstiks õppida");
            }
        }
    }
}
