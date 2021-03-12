using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class roket : MonoBehaviour
{
    Rigidbody2D myrb;
    private GameObject cube;
    private Vector3 direction;
    public GameObject ps;
    public GameObject anim;
    private Animator animComponent;
    private GameObject score;
    void Start()
    {
        score = GameObject.Find("Score");
        animComponent = anim.GetComponent<Animator>();
        myrb = GetComponent<Rigidbody2D>();
        cube = GameObject.Find("cube");
        direction = (cube.transform.position - transform.position).normalized * 5f;
        transform.up = direction;
        myrb.velocity = direction;

    }

    void Update()
    {

    }
    IEnumerator Stack()
    {
        animComponent.SetTrigger("stack");
        yield return new WaitForSeconds(0.5f);
        GameObject.Destroy(gameObject);
        cube.GetComponent<blabla>().stackRocket();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "base")
        {
            myrb.velocity = new Vector2(0, 0);
            StartCoroutine(Stack());
        }
        else if (collision.gameObject.tag == "merkez")
        {
            cube.GetComponent<blabla>().health -= 1;
            explode();
            GameObject.Destroy(cube.GetComponent<blabla>().hearts.transform.GetChild(0).gameObject);
        }
        else if(collision.gameObject.tag == "bullet")
        {
            explode();
        }
    }
    public void explode()
    {
        score.GetComponent<Score>().money += 10;
        Instantiate(ps, transform.position, Quaternion.identity);
        GameObject.Destroy(gameObject);
    }


}
