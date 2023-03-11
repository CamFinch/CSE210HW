public class Goal{
    private string _goalName, _goalDescription, _goalType;
    private int _points, _pointsWorth;
    
    public string GetGoalName(){
        return _goalName;
    }
    public void SetGoalName(string goalName){
        _goalName = goalName;
    }

    public string GetDescription(){
        return _goalDescription;
    }

    public void SetDescription(string goalDescription){
        _goalDescription = goalDescription;
    }

    public string GetGoalType(){
        return _goalType;
    }

    public void SetGoalType(string goalType){
        _goalType = goalType;
    }


    public List<Goal> goalList = new List<Goal>{};
    public void GetGoalInfo(){
        bool goalTypeMenu = true;
        while(goalTypeMenu){
            Console.WriteLine("Which Type of Goal Are You Setting?");
            Console.WriteLine("\n1. Simple Goal \n2. Eternal Goal \n3. Checklist Goal");
            Console.WriteLine("Select Option: ");
            string goalChoice = Console.ReadLine();

            if(goalChoice == "1"){
                _goalType = "Simple";
                
                goalTypeMenu = false;
                

            }
            else if(goalChoice == "2"){
                _goalType = "Eternal";
            
                goalTypeMenu = false;
               

            }
            else if(goalChoice == "3"){
                _goalType = "CheckList";
                
                goalTypeMenu = false;
               
            }   
            else{
                 Console.WriteLine("Incorrect Input Please Try Again!");
            }

        }
        Console.WriteLine("What is the Name of Your Goal?");
        _goalName = Console.ReadLine();
        Console.WriteLine("Short Description of Goal: ");
        _goalDescription = Console.ReadLine();
        
        if(_goalType == "Simple"){
            Simple s1 = new Simple();
            s1.SetGoalName(_goalName);
            s1.SetDescription(_goalDescription);
            s1.SetGoalType(_goalType);
            goalList.Add(s1);
            

        }
        else if(_goalType == "Eternal"){
            Eternal e1 = new Eternal();
            e1.SetGoalName(_goalName);
            e1.SetDescription(_goalDescription);
            e1.SetGoalType(_goalType);
            goalList.Add(e1);
        }
        else if(_goalType == "CheckList"){
            CheckList c1 = new CheckList();
            c1.SetGoalName(_goalName);
            c1.SetDescription(_goalDescription);
            c1.SetGoalType(_goalType);
            goalList.Add(c1);
        }

        
        
    }

    

    public void DisplayGoals(){
        foreach(Goal goal in goalList){
            Console.WriteLine(GetGoalName());
        }
    }

    public void SaveGoals(){
        Console.WriteLine("Name The File To Be Saved To: ");
        string newFileName = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(newFileName)){
            outputFile.WriteLine(goalList.ToString());
        
    }

    }

    public void LoadGoals(){
        Console.WriteLine("Enter File To Load From: ");
        string fileName = Console.ReadLine();
        List<string> lines = System.IO.File.ReadAllLines(fileName).ToList();
        foreach(string line in lines){
            
        }

    }

    public void RecordEvent(){
        Console.WriteLine("What Goal Have You Completed?");
        DisplayGoals();
        string stringEventChoice = Console.ReadLine();
        int eventChoice = int.Parse(stringEventChoice);
        
        
        
    }

    
}

