using UnityEngine;

public class HazardZone : MonoBehaviour
{
    // variables
    float elapsed = 0;


    // refrences
    [SerializeField] HealthSO health;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Player has entered the hazard zone!");
        health.DecreaseHealth(1);
    }

    private void OnTriggerStay(Collider other)
    {
        Debug.Log("Player is still in the hazard zone!");
        elapsed += Time.deltaTime;
        if (elapsed >= 2)
        {
            health.DecreaseHealth(1);
            elapsed = 0;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Player has left the hazard zone!");
    }
}
