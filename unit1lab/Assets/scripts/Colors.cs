using System.Collections;
using UnityEngine;

public class Colors : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    public void ChangeColor(Color color)
    {
        spriteRenderer.material.color = color;
    }

    public void Green()
    {
        ChangeColor(Color.green);
        StartCoroutine(ColorTime());
    }

    public void Yellow()
    {
        ChangeColor(Color.yellow);
        StartCoroutine(ColorTime());
    }

    IEnumerator ColorTime()
    {
        Debug.Log("started coroutine");
        yield return new WaitForSeconds(1.0f);
        ChangeColor(Color.white);
        Debug.Log("back to white");
    }
}
