using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class SheepBehaviors : MonoBehaviour
{
    [Header("Destination")]
    public Vector3 firstEnd;
    public Vector3 secondEnd;
    [Header("Arrival Time")]
    public float slowSheep;
    public float fastSheep;
    private float sheepSpeed;
   
    private float xLimits;
    private float zLimits;
    private Vector3 destination;
    
    void Start()
    {
        xLimits = Random.Range(firstEnd.x, secondEnd.x);
        zLimits = Random.Range(firstEnd.z, secondEnd.z);
        sheepSpeed = Random.Range(slowSheep, fastSheep);
        destination = new Vector3(xLimits, transform.position.y, zLimits);
        

    }

    // Update is called once per frame
    void Update()
    {
        transform.DOMove(destination, sheepSpeed).SetEase(Ease.Linear);
    }
}
