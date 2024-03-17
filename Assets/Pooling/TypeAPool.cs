using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class TypeAPool : BasePooler<GameObject>
{
    public float spawnDelay;
    public float destroyDelay;

    public override void Start()
    {
        base.Start();
        StartCoroutine(ItemSpawner());
    }

    private IEnumerator ItemSpawner()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawnDelay);
            var item = GetItem();
            item.SetActive(true);
            StartCoroutine(ItemDestroyer(item));
        }
    }
    private IEnumerator ItemDestroyer(GameObject item)
    {
        yield return new WaitForSeconds(destroyDelay);
        item.SetActive(false);
        ReleaseItem(item);
    }
}