using System;

class Program
{
    static void Main(string[] args)
    {
        List<Goal> goalss = new List<Goal>{};
        bool menuActive = true;
        
        while(menuActive){
            Console.Write("\nWelcome!");
            Console.WriteLine("\n1. Create New Goal \n2. List Goals \n3. Saves Goals \n4. Load Goals \n5. Record Events \n6. Quit");
            Console.WriteLine("\nSelect Option: ");
            string choice = Console.ReadLine();

            if(choice == "1"){
            Goal goal = new Goal();
            goal.GetGoalInfo();
        
            }
            
            else if(choice == "2"){
                Goal goal2 = new Goal();
                goal2.DisplayGoals();
               
            }
            else if(choice == "3"){
                Goal save1 = new Goal();
                save1.SaveGoals();
            }
            else if(choice == "4"){
               Goal load1 = new Goal();
               load1.LoadGoals();

            }
            else if(choice == "5"){
                Goal goal3 = new Goal();
                goal3.RecordEvent();

            }
            else if(choice == "6"){
                menuActive = false;
            }
        }

    }

    

    
}
