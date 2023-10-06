using System;

class Program
{
    static void Main(string[] args)
    {
        //EXEEDING REQUIREMENTS:
        //I made a list of scriptures and selected them randomly
        //The Scripture.HideRandomeWords() only hides undhidden words
        //Input validation, typing something besides quit or pressing enter doesn't break the program

        //Initialize reference
        Reference reference1 = new Reference("Proverbs",3,5,6);
        Reference reference2 = new Reference("John",3,16);
        Reference reference3 = new Reference("Alma",7,27);

        List<Scripture> scriptures = new List<Scripture>();
        //Initialize scripture
        Scripture scripture1 = new Scripture(reference1,"Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.");
        Scripture scripture2 = new Scripture(reference2,"For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");
        Scripture scripture3 = new Scripture(reference3,"And now, may the peace of God rest upon you, and upon your houses and lands, and upon your flocks and herds, and all that you possess, your women and your children, according to your faith and good works, from this time forth and forever. And thus I have spoken. Amen.");
        scriptures.Add(scripture1);
        scriptures.Add(scripture2);
        scriptures.Add(scripture3);

        Random random = new Random();
        int index = random.Next(scriptures.Count());
        Scripture scripture = scriptures[index];

        string userChoice = "";

        while(userChoice == "")
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress enter to continue or type 'quit to finish:");

            //get user input and Validate
            while(true)
            {
                string input = Console.ReadLine();
                input.ToLower();
                if (input == "" || input == "quit")
                {
                    userChoice = input;
                    break;
                }
                else
                {
                    Console.WriteLine("\nInvalid input, either press enter or type 'quit'");
                }

            }
        
        if(scripture.AreAllHidden())
        {
            break;
        }
        scripture.HideRandomWords(5,15);
        
        }
    }
}