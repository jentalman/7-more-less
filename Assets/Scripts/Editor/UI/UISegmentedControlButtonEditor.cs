using UI;
using UnityEditor;
using UnityEngine;

namespace Editor.UI
{
    [CustomEditor(typeof(OptionButton))]
    public class UISegmentedControlButtonEditor : UnityEditor.UI.ButtonEditor 
    {
        public override void OnInspectorGUI() {

            OptionButton component = (OptionButton)target;

            base.OnInspectorGUI();

            component.VImage = (GameObject)EditorGUILayout.ObjectField(nameof(component.VImage), component.VImage, typeof(GameObject), true);
            component.SelectedOptionImage = (GameObject)EditorGUILayout.ObjectField(nameof(component.SelectedOptionImage), component.SelectedOptionImage, typeof(GameObject), true);

        }
    }
}