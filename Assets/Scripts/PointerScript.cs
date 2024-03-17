using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.Diagnostics;

public class PointerScript : MonoBehaviour
{
    private Vector3 targetPosition;
    private RectTransform pointerRectTransform;
    public GameObject camera;
    public GameObject firstCanvas;

    

    private void Awake()
    {
        targetPosition = new Vector3(200,45);
        pointerRectTransform = transform.Find("Pointer").GetComponent<RectTransform>();

    }

   

    // Update is called once per frame
    void Update()
    {
        Vector3 toPosition = targetPosition;
        Vector3 fromPosition = camera.transform.position;
        fromPosition.z = 0f;
        Vector3 dir = (toPosition - fromPosition).normalized;
        float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        if (angle < 0) angle += 360;
        pointerRectTransform.localEulerAngles = new Vector3(0, 0, angle);
        
        Invoke("EndPointer",3f);
    }

    void EndPointer()
    {
        firstCanvas.SetActive(false);
        
    }
}
