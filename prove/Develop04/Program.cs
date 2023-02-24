using System;
using System.IO;

class Program
{
    
    static void Main(string[] args)
    {
        bool menuActive = true;
        Control control1 = new Control("Menu", "End");
        while(menuActive){
            Console.Write("Welcome!");
            Console.Write("\nMenu Options: \n");
            Console.WriteLine("\n1. Breathing Activity \n2. Reflecting Activity \n3. Listing Activity \n4. Quit");
            Console.WriteLine("\nSelect Option: ");
            string choice = Console.ReadLine();

            if(choice == "1"){
                Breathing breathing1 = new Breathing("Breathing Activity", "This activity will help you control your breathing.", "\nThanks for participating!");
                breathing1.BreathingStart();
            }
            else if(choice == "2"){
                
                Reflection reflection1 = new Reflection("Refelcting Activity", "This activity will help you reflect.", "\nThanks for participating!");
                reflection1.ReflectionStart();

            }
            else if(choice == "3"){

                Listing listing1 = new Listing("Listing Activity", "This activity allows you to list and ponder.", "\nThanks for participating!");
                listing1.ListingStart();
                

            }
            else if(choice == "4"){
                menuActive = false;

            }
            else{
                Console.WriteLine("Incorrect Input Please Try Again!");
                
            }
        }
        
    }
}