using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelMiamiBooking
{
    public class Hotel
    {
        public string Name { get; set; }
        public int Rating { get; set; }
        public double RegularWeekDayRate { get; set; }
        public double RegularWeekendRate { get; set; }
        public double RewardWeekDayRate { get; set; }
        public double RewardWeekendRate { get; set; }

        public Hotel    ()
        {

        }

        public Hotel(string name, int rating, double regularWeekDayRate, double regularWeekendRate, double rewardWeekDayRate, double rewardWeekendRate)
        {
            Name = name;
            Rating = rating;
            RegularWeekDayRate = regularWeekDayRate;
            RegularWeekendRate = regularWeekendRate;
            RewardWeekDayRate = rewardWeekDayRate;
            RewardWeekendRate = rewardWeekendRate;
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {


            var lines = System.IO.File.ReadAllLines(@"Input.txt");

            var lakeWood = new Hotel("Lakewood", 3, 110, 90, 80, 80);
            var bridgeWood = new Hotel("Bridgewood", 4, 160, 60, 110, 50);
            var rigdeWood = new Hotel("Ridgewood", 5, 220, 150, 100, 40);

            foreach (var line in lines)
            {
                Console.WriteLine(Calculate(line, lakeWood, bridgeWood, rigdeWood));
            }

            Console.ReadLine();
        }

        private static string Calculate(string input, Hotel lakeWood, Hotel bridgeWood, Hotel rigdeWood)
        {
            var lakeWoodSum = 0.0;
            var bridgeWoodSum = 0.0;
            var rigdeWoodSum = 0.0;

            var words = input.Split();

            if (input.Contains("Regular"))
            {
                for (var i = 1; i < 4; i++)
                {
                    if (words[i].Contains("sat") || words[i].Contains("sun"))
                    {
                        lakeWoodSum += lakeWood.RegularWeekendRate;
                        bridgeWoodSum += bridgeWood.RegularWeekendRate;
                        rigdeWoodSum += rigdeWood.RegularWeekendRate;
                    }
                    else
                    {

                        lakeWoodSum += lakeWood.RegularWeekDayRate;
                        bridgeWoodSum += bridgeWood.RegularWeekDayRate;
                        rigdeWoodSum += rigdeWood.RegularWeekDayRate;
                    }
                }
            }
            else
            {
                for (var i = 1; i < 4; i++)
                {
                    if (words[i].Contains("sat") || words[i].Contains("sun"))
                    {
                        lakeWoodSum += lakeWood.RewardWeekendRate;
                        bridgeWoodSum += bridgeWood.RewardWeekendRate;
                        rigdeWoodSum += rigdeWood.RewardWeekendRate;
                    }
                    else
                    {

                        lakeWoodSum += lakeWood.RewardWeekDayRate;
                        bridgeWoodSum += bridgeWood.RewardWeekDayRate;
                        rigdeWoodSum += rigdeWood.RewardWeekDayRate;
                    }
                }

            }

            return CompareSums(lakeWoodSum, bridgeWoodSum, rigdeWoodSum);
        }

        private static string CompareSums(double lakeWoodSum, double bridgeWoodSum, double rigdeWoodSum)
        {
            if (lakeWoodSum >= bridgeWoodSum && bridgeWoodSum < rigdeWoodSum) return "Bridgewood";

            if (lakeWoodSum >= rigdeWoodSum && rigdeWoodSum < bridgeWoodSum) return "Ridgewood";

            return "Lakewood";
        }
    }

}
