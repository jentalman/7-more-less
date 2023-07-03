using Model;
using UI.Model;
using UI.View;

namespace Presenter
{
    public class MoreLessPresenter
    {
        private readonly MoreLessModel _moreLessModel;
        private readonly IMoreLessView _moreLessView;

        protected MoreLessPresenter(MoreLessModel moreLessModel, IMoreLessView moreLessView)
        {
            _moreLessModel = moreLessModel;
            _moreLessView = moreLessView;
        }

        public void OnOptionButtonClick(int index)
        {
            _moreLessModel.SetOption(index);
            _moreLessView.SetButtonOption(index);
        }

        public void OnRollDiceButtonClick()
        {
            var diceResult =_moreLessModel.RollDice();
            _moreLessView.SetDiceResultText(diceResult);
        
            var isWin = _moreLessModel.IsWin();
            if (isWin)
            {
                _moreLessView.ShowVictory();
            }
        }
    }
}