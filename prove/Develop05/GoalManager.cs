using System.IO;

public class GoalManager 
{
    // Variable
    private List<Goal> _goals = new List<Goal>{};
    private int _score = 0;


    // Start method
    public void Start() 
    {
        bool running = true;
        
        while (running) {
            Console.WriteLine();
            DisplayPlayerInfo();
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create New Goal.");
            Console.WriteLine("  2. List Goals.");
            Console.WriteLine("  3. Save Goals.");
            Console.WriteLine("  4. Load Goals.");
            Console.WriteLine("  5. Record Event.");
            Console.WriteLine("  6. Quit.");
            Console.Write("Select a choice from the menu: ");

            switch (Console.ReadLine()) {
                case "1" :
                    CreateGoal();
                    break;
                case "2" :
                    ListGoalDetails();
                    break;
                case "3" :
                    Console.Write("What is the filename for the goal file? ");
                    string writeFile = Console.ReadLine();
                    SaveGoals(writeFile);
                    break;
                case "4" :
                    Console.Write("What is the filename for the goal file? ");
                    string readFile = Console.ReadLine();
                    LoadGoals(readFile);
                    break;
                case "5" :
                    Console.WriteLine("The goals are:");
                    ListGoalNames();
                    RecordEvent();
                    break;
                case "6" :
                    running = false;
                    break;
                default :
                    Console.WriteLine("Invalid Response.");
                    break;
            }
        }

    }

    // DisplayPlayerInfo method

    public void DisplayPlayerInfo() 
    {
        Console.WriteLine($"You have {_score} points.");
    }

    // ListGoalNames method

    public void ListGoalNames() 
    {
        for (int i = 0; i < _goals.Count; i ++) {
            Console.WriteLine($"  {i+1}. {_goals[i].GetName()}");
        }
    }

    // ListGoalDetails

    public void ListGoalDetails() 
    {
        Console.WriteLine("The goals are:");
        for (int i = 0; i < _goals.Count; i ++) {
            Goal goal = _goals[i];
            string mark;
            if (goal.IsComplete()) {
                mark = "X";
            }
            else {
                mark = " ";
            }
            Console.WriteLine($"  {i+1}. [{mark}] {goal.GetDetailsString()}");
        }
    }

    // CreateGoal method
    public void CreateGoal() 
    {
        Console.WriteLine("The types of goals are:");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        string newGoalType = Console.ReadLine();
        Console.Write("What is the name of your goal? ");
        string newGoalName = Console.ReadLine();
        Console.Write("What is a short Description of it? ");
        string newGoalDesctription = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        string newGoalPoints = Console.ReadLine();
        switch (newGoalType) {
            case "1" :
                _goals.Add(new SimpleGoal(newGoalName, newGoalDesctription, int.Parse(newGoalPoints), false));
                break;
            case "2" :
                _goals.Add(new EternalGoal(newGoalName, newGoalDesctription, int.Parse(newGoalPoints)));
                break;
            case "3" :
                Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                string newTarget= Console.ReadLine();
                Console.Write("What is the bonus for accomplishing it that many times? ");
                string newBonus = Console.ReadLine();
                _goals.Add(new ChecklistGoal(newGoalName, newGoalDesctription, int.Parse(newGoalPoints), 0, int.Parse(newTarget), int.Parse(newBonus)));
                break;
            default :
                Console.WriteLine("Invalid Response.");
                break;
        }
    }

    // RecordEvent method
    public void RecordEvent() 
    {
        Console.WriteLine("Which goal did you accomplish? ");
        Goal goal = _goals[int.Parse(Console.ReadLine()) - 1];
        _score += goal.RecordEvent();
    }

    // SaveGoals method
    public void SaveGoals(string filename) 
    {
        using (StreamWriter outputFile = new StreamWriter(filename)) {
            foreach (Goal goal in _goals) {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
    }

    // LoadGoals method
    public void LoadGoals(string filename) 
    {
        string[] lines = System.IO.File.ReadAllLines(filename);
        foreach (string line in lines) {
            string[] parts = line.Split(",");
            if (parts.Length == 4) {
                //It's a simpleGoal
                _goals.Add(new SimpleGoal(parts[0], parts[1], int.Parse(parts[2]), bool.Parse(parts[3])));
            }
            else if (parts.Length == 3) {
                //It's an eternal goal.
                _goals.Add(new EternalGoal(parts[0], parts[1], int.Parse(parts[2])));
            }
            else if (parts.Length == 6) {
                //It's a checklist goal.
                _goals.Add(new ChecklistGoal(parts[0], parts[1], int.Parse(parts[2]), int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[5])));
            } 
        }
    }
}