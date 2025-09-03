using UnityEngine;
using UnityEngine.Events;

public class TriggerZone : MonoBehaviour
{
    // Unity Events
    [SerializeField] UnityEvent onTriggerEnter;
    [SerializeField] UnityEvent onTriggerExit;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void OnTriggerEnter(Collider other)
    {
        onTriggerEnter.Invoke();
    }
    private void OnTriggerExit(Collider other) 
    {
        onTriggerExit.Invoke(); 
    }
}
