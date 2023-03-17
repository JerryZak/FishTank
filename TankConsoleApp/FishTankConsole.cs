using System;

namespace TankConsoleApp
{
    public class FishTankConsole
    {
        static void Main(string[] args)
        {
            start();
        }

        public static void start()
        {
            //options for user to select
            FishTank.Tank tankDAL = new FishTank.Tank();
            Console.WriteLine("Please select an option!");
            Console.WriteLine("1: Add Fish ");
            Console.WriteLine("2: Feed Fish ");

            string selectedoption = Console.ReadLine();
            int selectedoptionint = 0;
            int.TryParse(selectedoption, out selectedoptionint);
            string FishType = "";
            string FishName = "";
            int FishToAddOrFeedInt = 0;

            //Fish options for user to select
            Console.WriteLine("Please select your fish type");
            Console.WriteLine("1: Gold Fish");
            Console.WriteLine("2: Cat Fish");
            Console.WriteLine("3: Dog Fish");
            string FishToAddOrFeed = Console.ReadLine();
            int.TryParse(FishToAddOrFeed, out FishToAddOrFeedInt);

            Random random = new Random();
            int FishID = random.Next(1);
            //user fish selection
            switch (selectedoptionint)
            {
                case 1:
                    if (FishToAddOrFeedInt == 1)
                    {
                        FishType = "GOLD FISH";
                        Console.WriteLine($"A { FishType} is a nice choice");
                        Console.WriteLine($"Now it's time to name your {FishType}");
                        FishName = Console.ReadLine();
                    }
                    else if (FishToAddOrFeedInt == 2)
                    {
                        FishType = "CAT FISH";
                        Console.WriteLine($"A { FishType} is a nice choice");
                        Console.WriteLine($"Now it's time to name your {FishType}");
                        FishName = Console.ReadLine();
                    }
                    else if (FishToAddOrFeedInt == 3)
                    {
                        FishType = "DOG FISH";
                        Console.WriteLine($"A { FishType} is a nice choice");
                        Console.WriteLine($"Now it's time to name your {FishType}");
                        FishName = Console.ReadLine();
                    }

                    tankDAL.addFish(FishID, FishToAddOrFeedInt, FishName);
                    start();
                    break;
                case 2:
                    feedFish(FishToAddOrFeedInt, FishName);
                    start();
                    break;
            }
        }
        //feed the fish
        public static void feedFish(int fishType, string fishName)
        {
            FishTank.Tank tankDAL = new FishTank.Tank();

            tankDAL.feed(fishType, fishName);
        }
    }
}
