using Presenter;
using UI;
using UI.View;
using UnityEngine;
using Zenject;

namespace View
{
    public class MoreLessView : MonoBehaviour, IMoreLessView
    {
        private MoreLessPresenter _moreLessPresenter;
        private Buttons _button;

        [Inject]
        public void Construct(MoreLessPresenter moreLessPresenter, Buttons buttons)
        {
            _moreLessPresenter = moreLessPresenter;
            _button = buttons;
        }

        public void ShowVictory()
        {
            Debug.Log("Win");
        }

        public void OnRollDiceClick()
        {
            _moreLessPresenter.OnRollDiceButtonClick();
        }

        public void SetDiceResultText(int result)
        {
            Debug.Log(result);
        }

        public void OnOptionButtonClick(int index)
        {
            _moreLessPresenter.OnOptionButtonClick(index);
        
        }
        public void SetButtonOption(int index)
        {
            for (int i = 0; i < _button.optionButtons.Length; i++)
            {
                if (i == index)
                {
                    _button.optionButtons[i].Activate();
                }
                else
                {
                    _button.optionButtons[i].Deactivate();
                }
            }
        }
    }
}