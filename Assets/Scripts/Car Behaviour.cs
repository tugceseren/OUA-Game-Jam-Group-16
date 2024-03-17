using UnityEngine;

public class CarBehaviour : MonoBehaviour
{
    public float carSpeed = 2f;
    public GameObject spawnpoint;

    void Update()
    {
        // Move the car forward based on its current direction and speed
        transform.Translate(transform.forward * carSpeed * Time.deltaTime);
        
    
    }

    private void OnTriggerEnter(Collider other)
    {
        // Deactivate the car when it reaches the end of the road
        if (other.gameObject.CompareTag("EndOfRoad"))
        {
            transform.position = spawnpoint.transform.position;
        }

        
    }

   
}