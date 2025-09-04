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
        Debug.Log("Unity Event onTriggerEnter called!");
        onTriggerEnter.Invoke();
    }
    private void OnTriggerExit(Collider other) 
    {
        Debug.Log("Unity Event onTriggerExit called!");
        onTriggerExit.Invoke();
    }
}
