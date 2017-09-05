using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {

        //create a method called FavoriteFood
        //it should take two string parameters
        //Name of the food, and the other being the food 
        //it should be a void return type
        //the method should contenate the two values


        public static void FavoriteFood(string foodType, string foodName)
        {
            Console.WriteLine("I like " + foodType + "," + " my favorite is " + foodName);
                     
        }
       
      //make a retirement calculator that takes in an age and then tells he user how many years until they turn 65.
        public static void RetirementCalculator(int userAge)
        {
            int retirement = 65 - userAge;
            Console.WriteLine("The user will retire in " + retirement + " years.");

        }
        static void Main(string[] args)
        {

            string foodType = "cheese";
            string foodName = "swiss";
            FavoriteFood(foodType, foodName);
            FavoriteFood("candy", "skittles");

            int userAge = 40;
            RetirementCalculator(userAge);


        }
    }
}
