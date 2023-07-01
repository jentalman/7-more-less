using UnityEngine;
using Zenject;

public class MoreLessView : MonoBehaviour, IMoreLessView
{
    protected Presenter _presenter;
    private Buttons _button;

    [Inject]
    public void Construct(Presenter presenter, Buttons buttons)
    {
        _presenter = presenter;
        _button = buttons;
    }

    public void ShowVictory()
    {
        Debug.Log("Win");
    }

    public void OnRollDiceClick()
    {
        _presenter.OnRollDiceButtonClick();
    }

    public void UpdateDiceResultText(int result)
    {
        Debug.Log(result);
    }

    public void OnOptionButtonClick(int index)
    {
        _presenter.OnOptionButtonClick(index);
        
    }
    public void SetButtonOption(int index)
    {
        Debug.Log("Select option" + index);
    }
}