using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class bullet : MonoBehaviour
{
    private Rigidbody2D bulletrb;
    private float destroyTime;

    void Start()
    {
        bulletrb = GetComponent<Rigidbody2D>();
        bulletrb.velocity = transform.up * 8;
        destroyTime =Time.time+ 3.0f;
    }
    void Update()
    {

        if (Time.time > destroyTime)
        {
            Destroy(gameObject);
        }
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "roket")
        {
            GameObject.Destroy(gameObject);
        }
    }
}
