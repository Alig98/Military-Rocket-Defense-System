using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clonerocket : MonoBehaviour
{
    public GameObject rocket;
    private float nextSpawnTime;
    void Start()
    {
        nextSpawnTime = Time.time + 3.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if ((Time.time > nextSpawnTime))
        {
            Vector3 position = randomRangex();
            Instantiate(rocket, position, Quaternion.identity);
            nextSpawnTime += 1.5f;
        }
    }
    private Vector3 randomRangex()
    {
        Vector3 position;
        float randomValuex;
        float randomValuey;

        randomValuex = Random.Range(0.0f, 15.0f);
        randomValuey = Random.Range(0.0f, 25.0f);
        if(randomValuex<13.0f)
        {
            randomValuey = Random.Range(23.0f, 25.0f);
        }
        int randomMinus = Random.Range(0, 2);
        if (randomMinus == 0)
        {
            randomMinus = -1;
        }
        randomValuex= randomMinus * randomValuex;
        int randomMinus2 = Random.Range(0, 2);
        if (randomMinus2 == 0)
        {
            randomMinus2 = -1;
        }
        randomValuey = randomMinus2 * randomValuey;

        position = new Vector3(randomValuex, randomValuey, 0);
        return position;
    }
    private Vector3 randomRangey()
    {
        Vector3 position;
        float randomValuex;
        float randomValuey;

        randomValuex = Random.Range(0.0f, 15.0f);
        randomValuey = Random.Range(0.0f, 25.0f);
        if (randomValuey < 23.0f)
        {
            randomValuex = Random.Range(13.0f, 15.0f);
        }
        int randomMinus = Random.Range(0, 2);
        if (randomMinus == 0)
        {
            randomMinus = -1;
        }
        randomValuex = randomMinus * randomValuex;
        int randomMinus2 = Random.Range(0, 2);
        if (randomMinus2 == 0)
        {
            randomMinus2 = -1;
        }
        randomValuey = randomMinus2 * randomValuey;

        position = new Vector3(randomValuex, randomValuey, 0);
        return position;
    }
    private Vector3 randomRange()
    {
        Vector3[] positions = new Vector3[100];
        for(int i = 0; i < 45; i++){
            positions[i] = randomRangey();
        }
        for(int k=45; k<100; k++)
        {
            positions[k] = randomRangex();
        }
        int j = Random.Range(0, 100);

        return positions[j];
    }
}
