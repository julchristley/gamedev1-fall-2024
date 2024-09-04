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
    }
}
