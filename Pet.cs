using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace template_csharp_virtual_pet
{
    public class Pet
    {

        public string Name;
        
        public bool Happiness;
        public int Food;
        public int MaxHealth;
        public string PetType;
        public int Time;
        public bool Doctor;

        // for test
        public bool Hunger;
        public int Boredom;

       public Pet()
        {
            Food = 60;
            Boredom = 60;
           
            Time = 100;
        }
        public void PetName()
            
        {
            Console.WriteLine("What do you want to name your pet?");
            Name = Console.ReadLine();
        }
        public void Death()
        {
            if (MaxHealth <= 0) 
            {
               
                Console.WriteLine("Your pet has passed away!");
            }
            else
            {
                Console.WriteLine("Your pet is not feeling well! You should take them to the doctor.!");
            }
        }
        //public void Joy()
        //{
        //    if (Play < 60 && Play <=1)
        //    {
        //        Console.WriteLine("Would you want to play with your pet?");
        //        Play++;

        //    }
        //    else if (Play == 60)
        //    {
        //        Console.WriteLine("your pet is happy!");
        //    }
        //}
        public void CheckUp()
        {
            Console.WriteLine("The Vet healed your pet!");
            MaxHealth = 60;
        }
        //public void OverallHealth()
        //{
            
        //    //TimeSpan.FromDays(12);
        //    //TimeSpan.FromHours(24);
        //    //TimeSpan.FromMinutes(60);
        //    //DateTime currentDateTime = DateTime.Now;
        //    if (Play == 0 && Food == 0)
        //    {
        //        MaxHealth++;

        //    }
        //    else
        //    {
        //        MaxHealth--;
        //    }
            
        //} 
        public void Tick()
        {
          
            Console.WriteLine("Time: " + Time + "->" + --Time);
            Console.WriteLine("Food: " + Food + "->" + --Food);
            Console.WriteLine("Bored: " + Boredom + "->" + --Boredom);
            Console.WriteLine("Health: " + MaxHealth + "->" + --MaxHealth);

            Console.WriteLine("Please press the enter key to conintue");
            Console.ReadKey();
        }
        public void Play()
        {
            if (Boredom < 60)
            {
                Console.WriteLine("your pet is bored, would you like to play? Yes/No");
                Happiness = Console.ReadLine() == "Y" + "es" + "yes";
                if (Happiness)
                {
                    Boredom++;
                    MaxHealth--;
                    Console.WriteLine("bored: " + Boredom);
                }
                else
                {
                    Boredom--;
                    MaxHealth--;
                    Console.WriteLine("bored: " + Boredom);
                }

            }
            else if(Boredom == 60)
            {
                Console.WriteLine("your pet is happy");
            }

        }
        public void Nom()
        {
            if (Food <= 60 && Food >=1)
            {
                Console.WriteLine("your pet is hungry, would you like it feed it? Yes/No");
                Hunger = Console.ReadLine() == "Y" + "es" + "yes";
                if (Hunger) 
                {
                    Food++;
                    MaxHealth++;
                    Console.WriteLine("hungry: " + Food);
                }
                else
                {
                    Food--;
                    MaxHealth--;
                    Console.WriteLine("hungry: " + Food);
                }
            } else if (Food == 60)
            {
                Console.WriteLine("your pet is fed");
            }
        }
        public void Heal()
        {

        }

      

    }


    // if they are being played and fed, health goes up
    // if they are not being fed or played, health goes down - 
}

