using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    //add veribles
    public Rigidbody2D Rigidbody;
    public float lastFired;
    public GameObject ProjectillePrefab;
    public float Speed = 3;

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
        if (Random.Range(1, 500) == 1)
        {
            move = new Vector3(-0.50f, 0f, 0f);
        }

        if (Random.Range(1, 500) == 1)
        {
            move = new Vector3(0.50f, 0f, 0f);
        }
        this.transform.Translate(move);

        //timer to not fire to quickly
        if (Time.time > lastFired + 1)
        {
            if (Random.Range(1, 200) == 1)
            {
                  //move rocket and spawn
                  var Projectille = Instantiate(ProjectillePrefab, this.transform.position + this.transform.right * -1.5f, this.transform.rotation);
                  Projectille.GetComponent<Rigidbody2D>().velocity = transform.right * Speed;
                  lastFired = Time.time;
            }
            
        }
    }

    private void FixedUpdate()
    {
        //alow player to jump
        if (Random.Range(1, 500) == 1)
        {
            Rigidbody.AddForce(this.transform.up * 1 / 99);
        }
    }
}
