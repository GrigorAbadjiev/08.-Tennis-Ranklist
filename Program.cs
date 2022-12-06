using System;

namespace _08._Tennis_Ranklist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tournamentCount = int.Parse(Console.ReadLine());
            int startingPoints = int.Parse(Console.ReadLine());

            int tournamentsPointsSum = 0;
            int wonTournament = 0;  

            for (int i = 0; i < tournamentCount; i++)
            {
                string stage = Console.ReadLine();
                if (stage == "W")
                {
                    tournamentsPointsSum += 2000;
                    wonTournament++;
                }
                else if (stage == "F")
                {
                    tournamentsPointsSum += 1200;
                }
                else if (stage == "SF")
                {
                    tournamentsPointsSum += 720;
                }
            }
            Console.WriteLine($"Final points: {startingPoints + tournamentsPointsSum}");
            Console.WriteLine($"Average points: {Math.Floor(tournamentsPointsSum * 1.0 / tournamentCount)}");
            Console.WriteLine($"{wonTournament * 1.0 / tournamentCount * 100:f2}%");
        }
    }
}
