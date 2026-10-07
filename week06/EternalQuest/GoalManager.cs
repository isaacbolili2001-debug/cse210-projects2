using System;
using System.Collections.Generic;
using System.IO;

namespace EternalQuest
{
    public class GoalManager
    {
        private List<Goal> _goals;
        private int _score;

        public GoalManager()
        {
            _goals = new List<Goal>();
            _score = 0;
        }

        public List<Goal> GetGoals()
        {
            return _goals;
        }

        public void SetGoals(List<Goal> goals)
        {
            _goals = goals;
        }

        public int GetScore()
        {
            return _score;
        }

        public void SetScore(int score)
        {
            _score = score;
        }

        private string GetLevelTitle()
        {
            if (_score >= 1000) return "Legendary Quester Master (Level 5)";
            if (_score >= 3000) return "Master Disciple (Level 4)";
            if (_score >= 1500) return "Dedicated Seeker (Level 3)";
            if (_score >= 500) return "pathway Explorer (Level 2)";
            return "Novice Adventurer (Level 1)";
        }

        public void Start()
        {
            string Choice = "";
            while (Choice != "6")
            {
                DisplayPlayerInfo();
                Console.WriteLine("Menu Options:");
                Console.WriteLine("1. Create New Goal");
                Console.WriteLine("2. List Goals");
                Console.WriteLine("3. Save Goals");
                Console.WriteLine("4. Load Goals");
                Console.WriteLine("5. Record Event");
                Console.WriteLine("6. Quit");
                Console.Write("Select a choice from the menu: ");
                Choice = Console.ReadLine();

                switch (Choice)
                {
                    case "1":
                        CreateGoal();
                        break;
                    case "2":
                        ListGoalDetails();
                        break;
                    case "3":
                        SaveGoals();
                        break;
                    case "4":
                        LoadGoals();
                        break;
                    case "5":
                        RecordEvent();
                        break;
                    case "6":
                        Console.WriteLine("Exiting the program. Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        private void DisplayPlayerInfo()
        {
            Console.WriteLine();
            Console.WriteLine($"You have {_score} points.");
            Console.WriteLine($"Level: {GetLevelTitle()}");
            Console.WriteLine();
        }

        public void ListGoalNames()
        {
            Console.WriteLine("\nThe goals are:");
            for (int i = 0; i < _goals.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {_goals[i].GetShortName()}");
            }
        }
        public void ListGoalDetails()
        {
            Console.WriteLine("\nThe goals are:");
            for (int i = 0; i < _goals.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {_goals[i].GetDetailString()}");
            }
        }

        public void CreateGoal()
        {
            Console.WriteLine("\nThe type of Goals are:");
            Console.WriteLine("1. Simple Goal");
            Console.WriteLine("2. Eternal Goal");
            Console.WriteLine("3. Checklist Goal");
            Console.Write("Which type of goal would you like to create? ");
            string typeChoice = Console.ReadLine();

            Console.WriteLine("what is the name of your goal ");
            string name = Console.ReadLine();

            Console.WriteLine("What is a short description ot it ?");
            string description = Console.ReadLine();

            Console.WriteLine("What is the amount of points associated woth this goal ?");
            int points = int.Parse(Console.ReadLine());

            if (typeChoice == "1")
            {
                _goals.Add(new SimpleGoal(name, description, points));

            }
            else if (typeChoice == "2")
            {
                _goals.Add(new EternalGoal(name, description, points));
            }
            else if (typeChoice == "3")
            {
                Console.WriteLine("How many times does this goal need to be accomplished for a bonus?");
                int target = int.Parse(Console.ReadLine());

                Console.WriteLine("What is the bonus for accomplishing it that many times?");
                int bonus = int.Parse(Console.ReadLine());

                _goals.Add(new CheckListGoal(name, description, points, target, bonus));
            }
            else
            {
                Console.WriteLine("Invalid choice. Goal not created.");
            }
        }

        public void RecordEvent()
        {
            ListGoalNames();
            Console.Write("Which goal did you accomplish? ");
            int index = int.Parse(Console.ReadLine()) - 1;

            if (index >= 0 && index < _goals.Count)
            {
                Goal goal = _goals[index];
                if (goal is SimpleGoal simpleGoal)
                {
                    bool wasComplete = simpleGoal.IsComplete();
                    simpleGoal.RecordEvent();
                    if (!wasComplete && simpleGoal.IsComplete())
                    {
                        _score += simpleGoal.GetPoints();
                    }
                }
                else if (goal is EternalGoal eternalGoal)
                {
                    eternalGoal.RecordEvent();
                    _score += eternalGoal.GetPoints();
                }
                else if (goal is CheckListGoal checkListGoal)
                {
                    bool wasComplete = checkListGoal.IsComplete();
                    checkListGoal.RecordEvent();
                    if (!wasComplete)
                    {
                        _score += checkListGoal.GetPoints();
                        if (checkListGoal.IsComplete())
                        {
                            _score += checkListGoal.GetBonus();
                        }
                    }
                }
                Console.WriteLine($"Your now have: {_score} points.");
            }
            else
            {
                Console.WriteLine("Invalid goal selection.");
            }
        }

        public void SaveGoals()
        {
            Console.Write("Enter the filename to save goals: ");
            string filename = Console.ReadLine();

            using (StreamWriter writer = new StreamWriter(filename))
            {
                writer.WriteLine(_score);
                foreach (Goal goal in _goals)
                {
                    writer.WriteLine(goal.GetStringRepresentation());
                }
            }

            Console.WriteLine("Goals saved successfully.");
        }
        
        public void LoadGoals()
        {
            Console.Write("What is the filename for loading goals? ");
            string filename = Console.ReadLine();

            if (File.Exists(filename))
            {
                string[] lines = File.ReadAllLines(filename);
                _score = int.Parse(lines[0]);
                _goals.Clear();
                for (int i = 1; i < lines.Length; i++)
                {
                    string line = lines[i];
                    string[] parts = line.Split(':');
                    string type = parts[0];
                    String details = parts[1];
                    string[] values = details.Split(',');

                    if (type == "SimpleGoal")
                    {
                        _goals.Add(new SimpleGoal(values[0], values[1], int.Parse(values[2]), bool.Parse(values[3])));

                    }
                    else if (type == "EternalGoal")
                    {
                        _goals.Add(new EternalGoal(values[0], values[1], int.Parse(values[2])));
                    }
                    else if (type == "ChecklistGoal")
                    {
                        _goals.Add(new CheckListGoal(values[0], values[1], int.Parse(values[2]), int.Parse(values[3]), int.Parse(values[4]), int.Parse(values[5])));
                    }
                }
                Console.WriteLine("Goals loaded successfully.");
            }
            else
            {
                Console.WriteLine("File not found.");
            }
        }

    }
}