using System;

class Program
{
    static void Main(string[] args)
    {
        //EXEEDING REQUIREMENTS: 
        //Input validation on the menu selection to prevent a misstype from crashing the program. (Trycatch from 25 to 33) And added exeption handling to load menu option (46 to 53)
        //I made it so the user will not see the same prompt twice in row. (75 to 88)
        //I supplied a default file name and the user needs only to press enter to use it, or supply their own desired file name. (39 to 44 and  59 to 64)
        Console.WriteLine("\nWelcome to your journal\n");
        
        Journal journal = new Journal();
        string journalFileName = "myjournal.txt";

         int userChoice = 0; 
        

        while (userChoice != 5)
        {
            bool validChoice = true;
            DispleyMenu();
            userChoice = 0; 
            //get user input
            try 
            {
                userChoice = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("\nInvalid input please enter 1-5\n");
                validChoice = false;
            }

            //use user input to make a selection
            if(userChoice == 1)
            {
                //load journal from file 
                Console.Write("\nWhat file name yould you like to load from(Enter to use 'myjournal.txt')? ");
                string userFileName = Console.ReadLine();
                if(userFileName != "")
                {
                    journalFileName = userFileName;
                }
                
                try
                {
                    journal.ReadFromFile(journalFileName);
                    Console.WriteLine($"\nJournal loaded from {journalFileName}.\n");
                }catch(Exception)
                {
                    Console.WriteLine("\nOops! Something went wrong make sure the file you are trying to load exists and you typed the name correctly. Please try again.\n");
                }
                
                
            }
            else if( userChoice == 2)
            {
                Console.Write($"\nWhat file would you like to save to (Enter to use '{journalFileName}'? )");
                string userFileName = Console.ReadLine();
                if(userFileName != "")
                {
                    journalFileName = userFileName;
                }
                journal.WriteToFile(journalFileName);
                Console.WriteLine($"\nJournal saved to {journalFileName}.\n");

            }   
            else if( userChoice == 3)
            {
                
                Entry entry = new Entry();
                PromptGenerator promptGenerator = new PromptGenerator();
                DateTime theCurrentTime = DateTime.Now;
                string lastPrompt = "";
                string prompt = "";
                int journalLength = journal._entries.Count;

                if (journalLength >0)
                {
                    Entry lastEntry = journal._entries[journalLength -1];
                    lastPrompt = lastEntry._prompt;
                    //Console.WriteLine($"Your previous prompt was {lastPrompt}");
                }

                do{
                    prompt = promptGenerator.GetRandomPrompt();
                }while(String.Equals (lastPrompt, prompt));
                 
                Console.Write($"\n{prompt}\n>");

                entry._entryText = Console.ReadLine();
                entry._prompt = prompt;
                entry._date = theCurrentTime.ToShortDateString();
                journal._entries.Add(entry);
                Console.WriteLine("\nJournal entry added.\n");

            }
            else if( userChoice == 4)
            {
                journal.Display();
            }
            else if(userChoice != 5 && validChoice)
            {
                Console.WriteLine("\nInvalid input please enter 1-5\n");
            }




        }

        Console.WriteLine("\nGoodbye!\n");

       
        
    }


    static void DispleyMenu()
    {
        Console.WriteLine("1: Load");
        Console.WriteLine("2: Save");
        Console.WriteLine("3: Write");
        Console.WriteLine("4: Dsiplay");
        Console.WriteLine("5: Quit");
        
    }

    
}