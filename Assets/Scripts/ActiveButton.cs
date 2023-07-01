public class ActiveButton
{
    private int MinValue { get; }
    private int MaxValue { get; }

    public ActiveButton(int minValue, int maxValue)
    {
        MinValue = minValue;
        MaxValue = maxValue;
    }

    public bool CheckInRange(int diceSum) 
        => diceSum >= MinValue && diceSum <= MaxValue;
}