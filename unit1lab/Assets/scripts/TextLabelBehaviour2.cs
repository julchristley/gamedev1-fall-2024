using System.Globalization;
using UnityEngine;
using TMPro;

public class TextLabelBehaviour2 : MonoBehaviour
// there's 2 textlabelbehaviours because I have not figured out how to have one for both float and int data yet. I'm pretty sure it's possible.
// I'm going to try to merge them in the challenge
{
    public TextMeshProUGUI label;
    public IntData dataObj;

    private void Start()
    {
        label = GetComponent<TextMeshProUGUI>();
        UpdateLabel();
    }

    public void UpdateLabel()
    {
        label.text = dataObj.value.ToString(CultureInfo.InvariantCulture);
    }
}