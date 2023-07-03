using UnityEngine;
using UnityEngine.UI;

namespace UI
{
    public class OptionButton : Button
    {
        [SerializeField] public GameObject VImage;
        [SerializeField] public GameObject SelectedOptionImage;

        public void Activate()
        {
            VImage.SetActive(true);
            SelectedOptionImage.SetActive(true);
        }
    
        public void Deactivate()
        {
            VImage.SetActive(false);
            SelectedOptionImage.SetActive(false);
        }
    }
}