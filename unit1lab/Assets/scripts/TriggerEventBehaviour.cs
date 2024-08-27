using UnityEngine;
using UnityEngine.Events;
using MonoBehaviour = UnityEngine.MonoBehaviour;

public class TriggerEventBehaviour : MonoBehaviour
{
   public UnityEvent triggerEnterEvent;

   private void OnTriggerEnter(Collider other)
   {
      triggerEnterEvent.Invoke();
   }
}