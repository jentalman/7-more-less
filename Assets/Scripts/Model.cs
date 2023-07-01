using System;
using Unity.VisualScripting;
using Random = UnityEngine.Random;

public class Model
{
    private ActiveButton[] _activeButtonsIndex = new[]
    {
        new ActiveButton(2, 6),
        new ActiveButton(7, 7),
        new ActiveButton(8, 12),
    };

    public int ActiveButtonIndex { get; private set; }
    public int DiceResult { get; set; }
    
    public int RollDice()
    {
        int dice1 = Random.Range(1, 7);
        int dice2 = Random.Range(1, 7);
        DiceResult = dice1 + dice2;

        return DiceResult;
    }

    public void SetOption(int index)
    {
        if (index is >= 0 and <= 2)
        {
            ActiveButtonIndex = index; 
        }
        else
        {
            throw new InvalidOperationException();
        }
    }
    
    public bool IsWin()
    {
        ActiveButton activeButton = _activeButtonsIndex[ActiveButtonIndex];

        return activeButton.CheckInRange(DiceResult);
    }
}