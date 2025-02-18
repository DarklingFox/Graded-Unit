using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Got code for movmentfrom (DevHex, 2024)
public class PlayerControlls : MonoBehaviour
{
    //Add veriables
    public float speed;
    private float move;

    private Rigidbody2D rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        move = Input.GetAxisRaw("Horizontal");
        rigidbody.linearVelocityX = speed * move;
    }
}
