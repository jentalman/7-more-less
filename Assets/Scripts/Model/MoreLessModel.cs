using System;
using UI.Model;
using Random = UnityEngine.Random;

namespace Model
{
    public class MoreLessModel
    {
        private readonly OptionButtonModel[] _optionButtons = new[]
        {
            new OptionButtonModel(2, 6),
            new OptionButtonModel(7, 7),
            new OptionButtonModel(8, 12),
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
            OptionButtonModel optionButtonModel = _optionButtons[ActiveButtonIndex];

            return optionButtonModel.CheckInRange(DiceResult);
        }
    }
}