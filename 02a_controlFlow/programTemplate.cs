// Julian Guevara, Program Template, V0.1
using System;

namespace // UPDATE FOR EACH PROGRAM
{
    class program
    {
        static void Main(string[] args)
        {
           // DECLERATIONS
		   string favColor = "Purple";
		   int luckyNumber = 28;
		   float myGpa = 2.7f;
		   int myAge = 18;
		   bool pineappleOnPizza = true;
		   // if else Statements -- Check for a single condition!
		   if (favColor == "Green") {
		   console.WriteLine("Green with envy")
		   }
		   if (myAge >= 18) {
			   console.WriteLine("Permision granted")
		   }
		   // if - else statement -- checks for a single condition
           if (myAge > 15) {
				Console.WriteLine("You are eligible to drive")
		   } else {
			   Console.WriteLine("START WALKING SCRUB!");
		   }
		   
		   // if -- else if -- else -- Checks multiple outcomes.
		   if (myGpa == 4.0F) {
			   Console.WriteLine("Congrats on straight A grades!!");
		   } else if (myGpa >= 3.0F) {
				Console.WriteLine("Congrats on making honor roll!!");
		   } else if (myGpa >= 2.0F) {
			   Console.WriteLine("You are graduation ready!!");
		   } else {
			   Console.WriteLine("You should probably study!!");
		   }
        }  
		
		
		
    }
}
