using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    public string left;
    public string right;
    public string Jump;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(Update))
        {

        }

        if (Input.GetKey(Left))
        {
            this.transform.Rotate (new Vector3(0f, 1f, 0f) * deltaTime);
        }

    }
}
