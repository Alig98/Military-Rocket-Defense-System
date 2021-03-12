using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class blabla : MonoBehaviour
{
    private float moveHorizontal;
    public float health;
    private float rocketCount;
    private GameObject[] rockets;
    public GameObject hearts;
    private GameObject rocketsInScreen;
    public GameObject ps;
    public GameObject Score;    
    void Start()
    {
        rocketsInScreen = GameObject.Find("Rockets");
        hearts = GameObject.Find("Hearts");
        health = 10.0f;
        rocketCount = 0.0f;
    }

    void Update()
    {
        moveHorizontal = Input.GetAxis("Horizontal");
        transform.Rotate(0, 0, -moveHorizontal*3);
        if (health == 0)
        {
            //GameObject.Destroy(gameObject);
        }
        if (rocketCount == 10.0f)
        {
            Instantiate(ps, new Vector3(0, 0, 0), Quaternion.identity);
            rockets = GameObject.FindGameObjectsWithTag("roket");
            for(int i = 0; i < rockets.Length; i++)
            {
                rockets[i].GetComponent<roket>().explode();
            }
            for (int i = 0; i < rocketCount; i++)
            {
                rocketsInScreen.transform.GetChild(i).gameObject.SetActive(false);
            }
            rocketCount = 0;

        }
    }
    public void stackRocket()
    {
        rocketCount += 1;
        Score.GetComponent<Score>().money += 12;
        rocketsInScreen.transform.GetChild((int) rocketCount-1).gameObject.SetActive(true);
    }
}