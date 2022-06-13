using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace template_csharp_virtual_pet
{
    public class Robot : Pet
    {
        public string RobotType;
        public string RobotFood;
        public bool Doctor;

        public Robot()
        {
            Name = "Robot";
            RobotType = "Robot";
            MaxHealth = 100;
            Happiness = false;
            RobotFood = "oil";
        }
            
        
        public void RNoms()
        {
            Console.WriteLine("Yummy Oil!");
        }
        public void Play()
        {
            Console.WriteLine("I love playing Rockem' Sockem' Robot!");
        }

        public void RCheckup()
            // couldnt get this to work, wanted a different line for robot and doctor but since Pets is the parent class it was taking Pets and not Robot in the activePets.
        {
            if (Doctor = true)
            {

                Console.WriteLine("Sorry, Robots don't see doctors, they need to go see Gordi in Engineering");
                MaxHealth--;
            }
            else
            {
                MaxHealth--;
            }
        }


    }
}
