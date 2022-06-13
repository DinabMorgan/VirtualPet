// Your Program Code Here
using template_csharp_virtual_pet;
Shelter shelter = new Shelter();
Pet activePet = new Pet();
Robot robot = new Robot();

Console.WriteLine("Welcome to Max's Petdom!");


bool isRunning = true;
while (isRunning) 
{
    Console.WriteLine("Please select what you want to do!");
    Console.WriteLine("1. Create a new pet \n2. Look at all of your pets \n3. Interact with pet \n4. Exit game");
    
    int selection=Int32.Parse(Console.ReadLine());
    switch (selection)
    {
        case 1:
            Console.WriteLine("What type of pet would you like to add?");
            Console.WriteLine("1. Shark \n2. Raccoon \n3. Llama \n4. Octopus \n5. Robot");
            int animalSelection = Int32.Parse(Console.ReadLine());
          Pet ToAdd = new Pet();
           
           

            switch (animalSelection)
            {
                case 1: // creating a pet
                    Console.WriteLine("You chose a Shark!");
                    ToAdd.PetType = "Shark";
                    ToAdd.MaxHealth = 60;
                   
                    break;
                case 2:
                    Console.WriteLine("You chose a Raccoon!");
                    ToAdd.PetType = "Raccoon";
                    ToAdd.MaxHealth = 60;

                    break;
                case 3:
                    Console.WriteLine("You chose a Llama!");
                    ToAdd.PetType = "Llama";
                    ToAdd.MaxHealth = 60;
                    break;

                case 4:
                    Console.WriteLine("You chose an Octopus!");
                    ToAdd.PetType = "Octopus";
                    ToAdd.MaxHealth = 60;
                    break;

                case 5:
                    Console.WriteLine("you chose a Robot Pet!");
                    
                    ToAdd = new Robot();
                    ToAdd.MaxHealth = 100;
                    
                    break; 
            }
            ToAdd.PetName();
          
            shelter.Pets.Add(ToAdd);
            break;

        case 2:// look at all of your pets
            Console.WriteLine("Here is a list of your pets:");

            for (int i = 0; i < shelter.Pets.Count; i++ )
            {
                if (shelter.Pets[i].GetType() == typeof(Pet))
                {
                    Pet animal = shelter.Pets[i];
                    Console.WriteLine(i + "." + animal.Name + "- spieces: " + animal.PetType + "-Max Health: " +animal.MaxHealth);
                   
               
                } else if (shelter.Pets[i].GetType() == typeof(Robot))
                {
                    Robot animal = (Robot)shelter.Pets[i];
                    Console.WriteLine(i + "." + animal.Name + "-" + animal.RobotType + "-Max Health: " + animal.MaxHealth);
                }

            }

            Console.WriteLine("Please select a pet to interactive with");
            int response = Int32.Parse(Console.ReadLine());
            activePet = shelter.Pets[response];
            activePet.Tick();
            
            break;

        case 3:// interacting with the pet
            Console.WriteLine("what would you like to do?");
            Console.WriteLine("1. Feed Pet \n2. Play with pet \n3. Check current health of current pet  \n4. Take pet to doctor \n5. Go Back");
            int interact = Int32.Parse(Console.ReadLine());
            switch (interact)
            {
                case 1:
                   
                    activePet.Nom();
                    break;
                case 2:
                    activePet.Play();
                   
                    break;
                case 3:
                    activePet.Tick();
                    break;
                case 4:
                    activePet.CheckUp();
                   // activePets.RCheckup(); - couldnt get this to work - wanted a different line for robot
                    break;
                case 5:
                    Console.WriteLine("Please press the enter key to continue");
                    Console.ReadKey();
                    break;
            }




            break;
        case 4:// exting game
            isRunning = false;
            
            break;
       
        default:
            break;
    }
}


