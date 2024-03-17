using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalSpawn : MonoBehaviour
{
    public Transform Limit1;
    public Transform Limit2;
    public GameObject animal;
    
    private Vector3 _vector3;
    private float spawnX;
    private float spawnZ;
    
    
    void Start()
    {
        spawnX = Random.Range(Limit1.transform.position.x, Limit2.transform.position.x);
        spawnZ = Random.Range(Limit1.transform.position.z, Limit2.transform.position.z);

        _vector3 = new Vector3(spawnX, 1f, spawnZ);

        Instantiate(animal);
        animal.transform.position = _vector3;
        
        animal.SetActive(true);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
