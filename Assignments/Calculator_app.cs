using System;
using System.Threading;
using Microsoft.VisualBasic;

class Assignment 
{

static void Main () 
{
// This allows the main method to be called, resetting the whole program
 ExecuteMainLogic();
 
}

 //Calculating..(Method)
 public static void SimulateLoading()
    {
        Console.WriteLine("Calculating...");
        Thread.Sleep(500); // Delay for 500 milliseconds (0.5 seconds)
    }
 public static void ExecuteMainLogic() {


 // Greet User!
 Console.WriteLine ("Hello!");

 // Ask user for first number

 Console.WriteLine ("Please enter your first number: ");
 var userInput = Console.ReadLine();


 // *** Handling null reference error ***

 if (userInput == null)
{
    Console.WriteLine ("Error! Please enter a valid number");
    return;
}
 int number_1 = int.Parse (userInput);          



 // Ask user to input second number 

 Console.WriteLine ("Please enter your second number: ");
 var userInput_2 = Console.ReadLine();

 // *** Handling null reference error ***

 if (userInput_2 == null) 
{ 
 Console.WriteLine ("Error! Please enter a valid number");
    return;
}

 int number_2 = int.Parse (userInput_2);



 

 //Main menu font
 Menufont();
 
 
 //Menu Input
 char MenuSelect = Console.ReadKey(true).KeyChar;
 EndMenu(MenuSelect);




 //Main menu selection
 
 if (MenuSelect == 'A' || MenuSelect == 'a')  {
    Console.WriteLine();
    SimulateLoading();
    Console.WriteLine();
   int Result_A = Add(number_1,number_2);
    Console.WriteLine ($"{number_1} + {number_2} = {Result_A}");
    
 }
 else if (MenuSelect == 'S' || MenuSelect == 's')  {
    Console.WriteLine();
    SimulateLoading();
    Console.WriteLine();
   int Result_S = Minus(number_1,number_2);
    Console.WriteLine ($"{number_1} - {number_2} = {Result_S}");
    
 }
 else if (MenuSelect  == 'M' || MenuSelect == 'm')  {
    Console.WriteLine();
    SimulateLoading();
    Console.WriteLine();
   int Result_M = Multiply(number_1,number_2);
    Console.WriteLine ($"{number_1} * {number_2} = {Result_M}");
    
 }

 else {
   Console.WriteLine ("Invalid input!");
 }

  // End Menu
 Console.WriteLine();
 Console.WriteLine("[R]eset");
 Console.WriteLine("[E]xit");
 char Finale = Console.ReadKey(true).KeyChar;
 EndMenu(Finale);
 
 }


 //Addition method
 public static int Add (int a, int b) {
 return a + b;
 
 }

 //Subtract method
 public static int Minus (int a, int b) {
   return a - b;
 }

 //Multiply method
 public static int Multiply (int a, int b) {
   return a * b;
 }


 //End menu method
  public static void EndMenu (char EndOption) 
 {
 
 if (EndOption == 'R' || EndOption == 'r') {
    Console.WriteLine();
    ExecuteMainLogic();
    }
 else if (EndOption == 'E' || EndOption == 'e') {
 Console.WriteLine("Exiting...");
 Environment.Exit(1000);
 }
 

 }
 
 //Main menu font method
 public static void Menufont () {
 Console.WriteLine();
 Console.WriteLine ("What would you like to do..? ");
 Console.WriteLine ("[A]dd numbers");
 Console.WriteLine ("[S]ubtract numbers");
 Console.WriteLine ("[M]ultiply numbers");
 Console.WriteLine();
 Console.WriteLine("[R]eset");
 Console.WriteLine("[E]xit");
 }
 
 }
/******************************************************************************
 /* Need to handle exceptions for endmenu method , if user enters input
 it will just execute the else statement, exiting the program. I need a way to 
 repeat the "invalid input" statement or reset to main menu 

 

 void PrintAnswer (int number1, int number2, string @operator, int result)
 Console.WriteLine ($"{number1} + "@operator" + {number2} " = " {result}");

 PrintAnswer (number_1,number_2)*/
 


 
 

 
 