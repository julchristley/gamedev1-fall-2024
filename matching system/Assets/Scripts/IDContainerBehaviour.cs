using UnityEngine;
using UnityEngine.Events;

public class IDContainerBehaviour : MonoBehaviour
{
    //inherits from ID container behaviour
    public ID idObj;
    public UnityEvent startEvent;

    public void Start()
    {
        startEvent.Invoke();
    }
}
