using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //add veribles
    public string left = "a";
    public string right = "d";
    public string Jump = "w";
    public float Speed = 0.0f;
    public Rigidbody2D Rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        Rigidbody = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    // move player
    public void Update()
    {
        Vector3 move = new Vector3(0, 0);
        //I know some of code just rotates sprite, just trying to get it to do something first
        if (Input.GetKey(Jump))
        {
            this.transform.Rotate(new Vector3(0f, 5f, 0f) * Time.deltaTime * 1);
        }

        if (Input.GetKey(left))
        {
            this.transform.Rotate(new Vector3(0f, 0f, 50f) * Time.deltaTime);
            //move = new Vector3(0f, 0.1f, 0f);
        }

        if (Input.GetKey(right))
        {
            this.transform.Rotate(new Vector3(0f, 0f, -50f) * Time.deltaTime);
        }
        //this.transform.Translate(move);
    }

    private void FixedUpdate()
    {
        if (Input.GetKey(Jump))
        {
            Rigidbody.AddForce(this.transform.up * 5);
        }
    }
}
