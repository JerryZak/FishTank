using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace FishTank
{
    public class Tank
    {
        // This method shows the amount of food to give to the fish based on its type
        public void feed(int fishType, string fishName)
        {
            double foodAmount = 0;

            switch (fishType)
            {
                case 1:
                    foodAmount = 0.1;
                    break;
                case 2:
                    foodAmount = 0.2;
                    break;
                case 3:
                    foodAmount = 0.3;
                    break;
                default:
                    Console.WriteLine("Invalid fish type!");
                    return;
            }

            Console.WriteLine($"Fish {fishName} will be given {foodAmount}G of food");
        }

        // This method stores fish data to a JSON file
        public void addFish(int fishID, int fishType, string fishName)
        {
            var fishData = new
            {
                FISHID = fishID,
                FISHTYPE = fishType,
                FISHNAME = fishName
            };

            var filePath = "C:/Users/zunai/Desktop/Work/Interview/Belsham Tech/Tech Excercise/FishTank (2)/FishTank/Data/fishData.json";

            string json = File.Exists(filePath) ? File.ReadAllText(filePath) : "[]";

            var fishList = JsonConvert.DeserializeObject<List<object>>(json) ?? new List<object>();


            // Add the new fish data to the list
            fishList.Add(fishData);

            // Serialize the updated list
            json = JsonConvert.SerializeObject(fishList);

            // Write to JSON file
            File.WriteAllText(filePath, json);

            Console.WriteLine("Your Fish ID = " + fishID);
            Console.WriteLine("Your Fish Type = " + fishType);
            Console.WriteLine("Your Fish Name = " + fishName);
        }

    }
}
