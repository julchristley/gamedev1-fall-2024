using UnityEngine;
using UnityEngine.Events;
[CreateAssetMenu]

public class IntData : ScriptableObject
{
    public int value;

    public void SetValue(int num)
    {
        value = num;
    }

    public void SetValue(IntData obj)
    {
        value = obj.value;
    }

    public void CompareValue(IntData obj)
    {
        if (value >= obj.value)
        {
            //if value is equal or greater, don't do anything
        }
        else
        {
            value = obj.value;
        }
    }

    public void UpdateValue(int num)
    {
        value += num;
    }

}
