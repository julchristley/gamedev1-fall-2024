using System;
using UnityEngine;
using UnityEngine.Events;

public class MonoEventsBehaviour : MonoBehaviour
{
    public UnityEvent startEvent, awakeEvent, disableEvent, triggerEvent, enterEvent;
    private Colors colors;
    
    private void Awake()
    {
        awakeEvent.Invoke();
    }

    private void Start()
    {
        startEvent.Invoke();
        colors = GetComponent<Colors>();
    }

    private void OnDisable()
    {
        disableEvent.Invoke();
    }

    private void OnTriggerExit(Collider other)
    {
        colors.Green();
    }

    private void OnMouseEnter()
    {
        
    }
}
