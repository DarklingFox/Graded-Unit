using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveThePlayer : MonoBehaviour
{
    //add veribles
    public string left;
    public string right;
    public string Jump;
    public Rigidbody2D Rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        Rigidbody = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    // move player
    void Update()
    {
        if (Input.GetKey(Jump))
        {
           // this.transform.Rotate (new Vector3(0f, 5f, 0f) * deltaTime * 1);
        }

        if (Input.GetKey(left))
        {
          //  this.transform.Rotate(new Vector3(0f, 0f, 50f) * deltaTime);
        }

        if (Input.GetKey(right))
        {
          //  this.transform.Rotate(new Vector3(0f, 0f, -50f) * deltaTime);
        }
    }

    private void FixedUpdate()
    {
       // if (Input.GetKey(Up))
        {
           Rigidbody.AddForce(this.transform.up * 5);
        }
    }
}
