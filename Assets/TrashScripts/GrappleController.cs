using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrappleController : MonoBehaviour
{
    private bool touching = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G)&& touching)
        {
            Debug.Log("Grabbing");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            touching = true;
        }

        else
        {
            touching = false;
            Debug.Log("not");
        }
    }
}
