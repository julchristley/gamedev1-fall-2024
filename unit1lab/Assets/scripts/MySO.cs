using UnityEngine;
using TMPro;
using System.Collections;

[CreateAssetMenu]

// this script pops up text everytime the player interacts with an object
public class MySO : ScriptableObject
{
    public string value;
    private TMP_Text uiText;

    public void Initialize(TMP_Text textComponent)
    {
        uiText = textComponent;
        uiText.gameObject.SetActive(false);
    }

    public void ShowText()
    {
        uiText.text = value;
        uiText.gameObject.SetActive(true);
    }

    public void HideText()
    {
        uiText.gameObject.SetActive(false);
    }
}
