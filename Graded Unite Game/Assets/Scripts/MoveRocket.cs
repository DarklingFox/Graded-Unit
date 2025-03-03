using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRocket : MonoBehaviour
{
    //Add Veriables 
    public GameObject Rocket;
    Rigidbody2D Rigidbody;
    public float Speed = 3;

    // Start is called before the first frame update
    void Start()
    {
        //set component
        Rigidbody = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //add veriable
        Vector3 move = new Vector3(0, 0);

        //move rocket
        //move = new Vector3(-0.01f, 0f, 0f);

        var Rocket = Instantiate(RocketPrefab, Rocket)
    }

    //have rocket despawn on collision
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Destroy(this.gameObject);
        }

        if (collision.gameObject.tag == "Wall")
        {
            Destroy(this.gameObject);
        }
    }
}

