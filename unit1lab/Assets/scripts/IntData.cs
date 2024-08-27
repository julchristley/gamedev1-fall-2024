using UnityEngine;

[CreateAssetMenu]

public class IntData : ScriptableObject
{
    public int value;

    public void IncreaseScore(int amount)
    {
        value += amount;
    }
}
