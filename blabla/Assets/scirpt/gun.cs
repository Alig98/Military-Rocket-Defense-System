using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gun : MonoBehaviour
{
    public GameObject bullet;
    public GameObject roket;
    private float nextSpawnTime;

    void Start()
    {
        nextSpawnTime = Time.time + 3.0f;

    }
    void Update()
    {
        if ((Time.time > nextSpawnTime))
        {
            Instantiate(bullet, transform.position, transform.rotation);
            nextSpawnTime += 0.5f;
        }
    }
}