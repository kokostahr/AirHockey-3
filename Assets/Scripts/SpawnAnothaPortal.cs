using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnAnothaPortal : MonoBehaviour
{
    public SpawnPortal portal;
    public GameObject otherPortal;
    public bool haltSpawning = false;



    public void Start()
    {
        InvokeRepeating("SpawnAnotharPortal", portal.spawnTime, portal.spawnDelay);
    }

    public void SpawnAnotharPortal()
    {
        GameObject np2 = Instantiate(otherPortal, this.transform) as GameObject;
        np2.transform.localPosition = new Vector3(Random.Range(-8.1f, 7f), -3.7f, 0);

        if (haltSpawning) //If its true
        {
            CancelInvoke("SpawnAnotharPortal");
        }
    }
}
