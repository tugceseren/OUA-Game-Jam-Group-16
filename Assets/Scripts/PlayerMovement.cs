using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed = 8f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float hoirzontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 movementDirection = new Vector3(hoirzontalInput, verticalInput, 0);
        
        movementDirection.Normalize();
        
        transform.Translate(movementDirection * speed * Time.deltaTime,Space.World);

        if (movementDirection != Vector3.zero)
        {
            transform.forward = movementDirection;
        }
    }
}
