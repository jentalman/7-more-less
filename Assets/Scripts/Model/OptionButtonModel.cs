namespace UI.Model
{
    public class OptionButtonModel
    {
        private int MinValue { get; }
        private int MaxValue { get; }

        public OptionButtonModel(int minValue, int maxValue)
        {
            MinValue = minValue;
            MaxValue = maxValue;
        }

        public bool CheckInRange(int diceSum) 
            => diceSum >= MinValue && diceSum <= MaxValue;
    }
}