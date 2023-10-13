using System.IO;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;
    private string _fileName;
    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
        _fileName = "goals.txt";
    }

    public void Start()
    {
        bool stillPlaying = true;
        while (stillPlaying)
        {
            Console.Clear();
            DisplayPlayerInfo();
            Console.WriteLine("\nMenu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");
            int menuChoice = GetIntFromUser("Select a choice fromt the menu: ", 1, 6);
            switch(menuChoice)
            {
                case 1:
                    CreateGoal();
                    break;
                case 2:
                    ListGoalDetails();
                    break;
                case 3:
                    SaveGoals();
                    break;
                case 4:
                    LoadGoals();
                    break;
                case 5:
                    RecordEvent();
                    break;
                case 6:
                    stillPlaying = false;
                    break; 
            }


        }
    }

    public void DisplayPlayerInfo()
    {
        
        string[] ranks = {"Goal Setter", "Goal Getter", "Goal Achiever", "Goal SUPER Acheiver", "Goal Mega Acheiver", "Goal Master", "Goal Dominator"};
        int[] rankUpAt = {50, 500, 1000, 2000, 5000, 10000, 20000};
        string rank = "";
        int amountToNextRank = 0;
        bool maxRank = false;
        for (int i = 0; i < ranks.Count(); i++)
        {
            if (_score >= 10000)
            {
                rank = ranks[6];
                maxRank = true;
                break;
            }

            rank = ranks[i]; 
            if (_score < rankUpAt[i])
            {
                amountToNextRank = rankUpAt[i] - _score;
                break;
            }   
        }

        if (maxRank)
        {
            Console.WriteLine($"You have {_score} points. Your current rank is {rank} Congratulations! You have reached max rank!.");
        }
        else
        {
            Console.WriteLine($"You have {_score} points. Your current rank is {rank} earn {amountToNextRank} points to rank up.");
        }
    }   

    public void ListGoalNames()
    {
        Console.WriteLine("The goals are:");
        int i = 1;
        foreach(Goal goal in _goals)
        {
            Console.WriteLine($"{i}. {goal.GetShortName()}");
            i ++;
        }
        
    }

    public void ListGoalDetails()
    {
         Console.Clear();
        Console.WriteLine("Your current goals are:");
        int i = 1;
        foreach(Goal goal in _goals)
        {
            Console.WriteLine($"{i}. {goal.GetDetailsString()}");
            i ++;
        }
        Console.WriteLine("Press enter to return to main menu:");
        Console.ReadLine();
    }

    public void CreateGoal()
    {
        Console.Clear();
        Console.WriteLine("The types of goals are:");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");
        int goalChoice = GetIntFromUser("Which typ of goal would you like to create? ", 1,3);
        string whatName = "What is the name of your goal? ";
        string whatDescription = "What is a short description of your goal? ";
        string whatPoints = "What is the amount of points associated with this goal? ";
        
        switch (goalChoice)
        {
            case 1:
                SimpleGoal simpleGoal = new SimpleGoal(GetStringFromUser(whatName), GetStringFromUser(whatDescription),GetIntFromUser(whatPoints, 1 , 10000) );
                _goals.Add(simpleGoal);

                break;
            case 2:
                Eternalgoal eternalgoal = new Eternalgoal(GetStringFromUser(whatName), GetStringFromUser(whatDescription),GetIntFromUser(whatPoints, 1 , 10000));
                _goals.Add(eternalgoal);
                break;
            case 3:
                string howMany = "How many times does this goal need to be accomplished for a bonus?";
                string whatBonus = "What is the bonus for accomplishing this goal that many times?";
                ChecklistGoal checklistGoal = new ChecklistGoal(GetStringFromUser(whatName), GetStringFromUser(whatDescription),GetIntFromUser(whatPoints, 1 , 10000),GetIntFromUser(howMany, 1, 500), GetIntFromUser(whatBonus, 1, 10000));
                _goals.Add(checklistGoal);
                break;
        }
    }

    public void RecordEvent()
    {
        Console.Clear();
        ListGoalNames();
        int recordIndex = GetIntFromUser("Which Goal did you Accomplish? ", 1, _goals.Count) - 1;
        Goal recordedGoal = _goals[recordIndex];

        recordedGoal.RecordEvent();
        int startScore = _score;
        _score += recordedGoal.GetPoints();
        _score += recordedGoal.AddBonus();

        Console.WriteLine($"Congratulations! you have hearned {_score - startScore} points!");
        Console.WriteLine("Press enter to return to main menu:");
        Console.ReadLine();
        
    }

    public void SaveGoals()
    {
        string userFileName = GetStringFromUser($"What is the filename for the goal file(press enter to use default '{_fileName}')? ");
        if (userFileName != "")
        {
            _fileName = userFileName;
        }
        
        using (StreamWriter outputFile = new StreamWriter(_fileName))
        {
            outputFile.WriteLine(_score);
            foreach(Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }

    }

    public void LoadGoals()
    {
        string userFileName = GetStringFromUser($"What is the filename for the goal file(press enter to use current '{_fileName}')? ");
        if (userFileName != "")
        {
            _fileName = userFileName;
        }
        string[] strings = System.IO.File.ReadAllLines(_fileName);
        int i = 0;
        _score += int.Parse(strings[i]);
        i++;
        while(i < strings.Count())
        {
            string[] parts = strings[i].Split("|");
            string GoalType = parts[0];
            switch(GoalType)
            {
                case "SimpleGoal":
                    SimpleGoal simpleGoal = new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]), bool.Parse(parts[4]));
                    _goals.Add(simpleGoal);
                    break;
                case "EternalGoal":
                    Eternalgoal eternalgoal = new Eternalgoal(parts[1], parts[2], int.Parse(parts[3]));
                    _goals.Add(eternalgoal);
                    break;
                case "ChecklistGoal":
                    ChecklistGoal checklistGoal = new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[5]), int.Parse(parts[6]));
                    _goals.Add(checklistGoal);
                    break;
            }

            i++;
        }

    }

    private int GetIntFromUser(String prompt, int min, int max)
    {
        Console.Write(prompt);
        int userInput = -1;
        string retry = $"Invalid input: Please enter a number between {min} and {max}.";
        while(true)
        {
            try
            {
                userInput = int.Parse(Console.ReadLine());
                if(userInput >= min && userInput <= max)
                {
                    break;
                }
                else
                {
                    Console.WriteLine(retry);    
                }
            }
            catch
            {
                Console.WriteLine(retry);
            }
            
        }
        return userInput;
    }

    private string GetStringFromUser(string prompt)
    {
        Console.Write(prompt);
        return Console.ReadLine();
    }
}