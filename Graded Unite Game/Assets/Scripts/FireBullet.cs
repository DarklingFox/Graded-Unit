using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBullet : MonoBehaviour
{

    //Add Veriables 
    public string fire;
    public float lastFired;
    public GameObject Rocket;
    Rigidbody2D Rigidbody;

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
        GameObject firedBullet;
        Vector3 move = new Vector3(0, 0);

        //get Rocket to fire
        if (Input.GetKey (fire))
        {
            if (Time.time > lastFired + 1)
            {
                firedBullet = Instantiate(Rocket, this.transform.position + (this.transform.up * 10), this.transform.rotation);
                lastFired = Time.time;
            }
            move = new Vector3(-0.01f, 0f, 0f);
        }
    }
}
