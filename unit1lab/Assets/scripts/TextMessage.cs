using System.Collections;
using UnityEngine;
using TMPro;
public class TextMessage : MonoBehaviour
{
    public MySO textMessage;

    public TMP_Text uiText;

    public float textDuration = 1.0f;
    
    // Start is called before the first frame update
    void Start()
    {
        textMessage.Initialize(uiText);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            textMessage.ShowText();
            StartCoroutine(HideText(textDuration));
        }
    }

    private IEnumerator HideText(float duration)
    {
        yield return new WaitForSeconds(duration);
        textMessage.HideText();
    }
}