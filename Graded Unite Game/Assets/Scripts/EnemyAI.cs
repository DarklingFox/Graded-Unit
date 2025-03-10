using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    //add veribles
    public string left = "a";
    public string right = "d";
    public string Jump = "w";
    public string Fire = "f";
    public Rigidbody2D Rigidbody;
    public float lastFired;
    public GameObject FireballPrefab;
    public float Speed = 3;
    public float RandomNumber = 0f;

    // Start is called before the first frame update
    void Start()
    {
        Rigidbody = this.GetComponent<Rigidbody2D>();

        //initalise variables
        lastFired = 0;
    }

    // Update is called once per frame
    // move player
    public void Update()
    {
        // Vector variable and random number
        Vector3 move = new Vector3(0, 0);

        //move left and right
        if (Input.GetKey(right))
        {
            RandomNumber = Random.Range(1, 10);
            move = new Vector3(-0.01f, 0f, 0f);
        }

        if (Input.GetKey(right))
        {
            move = new Vector3(0.01f, 0f, 0f);
        }
        this.transform.Translate(move);

        //timer to not fire to quickly
        if (Time.time > lastFired + 1)
        {
            //move rocket and spawn
            if (Input.GetKey(Fire))
            {
                var Rocket = Instantiate(FireballPrefab, this.transform.position + this.transform.right * 1.5f, this.transform.rotation);
                Rocket.GetComponent<Rigidbody2D>().velocity = transform.right * Speed;
                lastFired = Time.time;
            }
        }
    }

    private void FixedUpdate()
    {
        //alow player to jump
        if (Input.GetKey(Jump))
        {
            Rigidbody.AddForce(this.transform.up * 1 / 99);
        }
    }
}
