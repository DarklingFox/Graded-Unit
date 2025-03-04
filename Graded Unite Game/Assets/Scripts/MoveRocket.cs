using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRocket : MonoBehaviour
{
    //Add Veriables 
    public string Fire = "f";
    public float lastFired;
    public GameObject RocketPrefab;
    public Transform Rocketspawn;
    Rigidbody2D Rigidbody;
    public float Speed = 3;

    // Start is called before the first frame update
    void Start()
    {
        //set component
        Rigidbody = this.GetComponent<Rigidbody2D>();

        //initalise variables
        lastFired = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //add veriable
        //Vector3 move = new Vector3(0, 0);

        //timer to not fire to quickly
        if (Time.time > lastFired + 1)
        {
            //move rocket and spawn
            if (Input.GetKey(Fire))
            {
                //learnd code from (School, 2025)
                var Rocket = Instantiate(RocketPrefab, Rocketspawn.position, Rocketspawn.rotation);
                Rocket.GetComponent<Rigidbody2D>().velocity = Rocketspawn.up * Speed;
            }
        }
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

