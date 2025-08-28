using Unity.VisualScripting;
using UnityEngine;

public class TriggerZone : MonoBehaviour
{
    PlayerMovement player;
    float elapsed;
    bool inHazardZone;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player = FindAnyObjectByType<PlayerMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        elapsed += Time.deltaTime;

        if (elapsed >= 2 && inHazardZone)
        {
            Debug.Log("Player Damaged!");
            //player.Damage();
            elapsed = 0;
        }


    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Player has entered the hazard zone!");
        inHazardZone = true;
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Player has left the hazard zone!");
        inHazardZone = false;
    }
}
