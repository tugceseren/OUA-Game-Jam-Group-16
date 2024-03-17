using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollusionActions : MonoBehaviour
{
    public GameObject animal;
    public GameObject returnCanvas;
    private bool endAble = false;
    
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Animal"))
        {
            
            animal.SetActive(false);
            endAble = true;
            
        }

       if (other.gameObject.CompareTag("Rocket"))
       {
           if (endAble)
           {
               //SceneManager.LoadScene();
           }

           else
           {
               returnCanvas.SetActive(true);
               Invoke("ReturnCanvasEnder",2f);
           }
         
       }

       if (other.gameObject.CompareTag("Obstacle"))
       {
           //SceneManager.LoadScene()
       }
    }

    void ReturnCanvasEnder()
    {
        returnCanvas.SetActive(false);
    }
    
    

   
}
