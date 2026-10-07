using System;

namespace EternalQuest
{
    public class CheckListGoal : Goal
    {
        private int _amountCompleted;
        private int _target;
        private int _bonus;

        public CheckListGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
        {
            _amountCompleted = 0;
            _target = target;
            _bonus = bonus;
        }

        public CheckListGoal(string name, string description, int points, int target, int bonus, int amountCompleted) : base(name, description, points)
        {
            _amountCompleted = amountCompleted;
            _target = target;
            _bonus = bonus;
        }

        public int GetAmountCompleted()
        {
            return _amountCompleted;
        }

        public void SetAmountCompleted(int amountCompleted)
        {
            _amountCompleted = amountCompleted;
        }

        public int GetTarget()
        {
            return _target;
        }

        public void SetTarget(int target)
        {
            _target = target;
        }

        public int GetBonus()
        {
            return _bonus;
        }

        public void SetBonus(int bonus)
        {
            _bonus = bonus;
        }

        public override void RecordEvent()
        {
            if (_amountCompleted < _target)
            {
                _amountCompleted++;
                if (_amountCompleted == _target)
                {
                    Console.WriteLine($"Congratulations! You have completed the checklist goal and earned {GetPoints() + _bonus} points.");
                }
                else
                {
                    Console.WriteLine($"Congratulation! You have earned {GetPoints()} points.");
                }
            }
            else
            {
                Console.WriteLine("This goal has already been completed.");
            }
        }

        public override bool IsComplete()
        {
            return _amountCompleted >= _target;
        }

        public override string GetDetailString()
        {
            string status = IsComplete() ? "[X]" : "[ ]";
            return $"{status} {GetShortName()} ({GetDescription()}) -- Currently completed: {_amountCompleted}/{_target}";
        }

        public override string GetStringRepresentation()
        {
            return $"CheckListGoal:{GetShortName()},{GetDescription()},{GetPoints()}, {_bonus}, {_target}, {_amountCompleted}";
        }
    }
}