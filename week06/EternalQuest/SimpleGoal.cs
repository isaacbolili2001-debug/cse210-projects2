

namespace EternalQuest
{
    public class SimpleGoal : Goal
    {
        private bool _isComplete;

        public SimpleGoal(string name, string description, int points) : base(name, description, points)
        {
            _isComplete = false;
        }

        public SimpleGoal(string name, string description, int points, bool isComplete) : base(name, description, points)
        {
            _isComplete = isComplete;
        }

        public bool GetIsComplete()
        {
            return _isComplete;
        }

        public void SetIsComplete(bool isComplete)
        {
            _isComplete = isComplete;
        }
        public override void RecordEvent()
        {
            if (!_isComplete)
            {
                _isComplete = true;
                Console.WriteLine($"Congratulations! You have earned {GetPoints()} points.");
            }
            else
            {
                Console.WriteLine("This goal has already been completed.");
            }
        }

        public override bool IsComplete()
        {
            return _isComplete;
        }

        public override string GetStringRepresentation()
        {
            return $"SimpleGoal:{GetShortName()},{GetDescription()},{GetPoints()}|{_isComplete}";
        }


    }
}