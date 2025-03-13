using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireEnemyProjectille : MonoBehaviour
{
    //Add Veriables 
    Rigidbody2D Rigidbody;
    public float Speed = -3;

    // Start is called before the first frame update
    void Start()
    {
        //set component
        Rigidbody = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    //have rocket despawn on collision
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(this.gameObject);
        }

        if (collision.gameObject.tag == "Wall")
        {
            Destroy(this.gameObject);
        }

        if (collision.gameObject.tag == "Projectille")
        {
            Destroy(this.gameObject);
        }
    }
}

