public class Presenter
{
    protected Model _model;
    protected IMoreLessView MoreLessView;

    protected Presenter(Model model, IMoreLessView moreLessView)
    {
        _model = model;
        MoreLessView = moreLessView;
    }

    public void OnOptionButtonClick(int index)
    {
        _model.SetOption(index);
        MoreLessView.SetButtonOption(index);
    }

    public void OnRollDiceButtonClick()
    {
        var diceResult =_model.RollDice();
        MoreLessView.UpdateDiceResultText(diceResult);
        
        var isWin = _model.IsWin();
        if (isWin)
        {
            MoreLessView.ShowVictory();
        }
    }
}