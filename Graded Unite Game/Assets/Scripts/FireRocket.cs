using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireRocket : MonoBehaviour
{
    //Add Veriables 
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

    }

    //have rocket despawn on collision
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(this.gameObject);
        }

        else if (collision.gameObject.CompareTag("Wall"))
        {
            Destroy(this.gameObject);
        }

        else if (collision.gameObject.CompareTag("Projectille"))
        {
            Destroy(this.gameObject);
        }
    }
}
