using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    Rigidbody rb;
    public int forwardSpeed;
    public int backardSpeed;
    public int leftSpeed;
    public int rightSpeed;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("w")){
            Vector3 forward = new Vector3(1,0,0);
            rb.velocity = forward * forwardSpeed;
        }
        if(Input.GetKeyDown("s")){
            Vector3 backward = new Vector3(-1,0,0);
            rb.velocity = backward * backardSpeed;
        }
        if(Input.GetKeyDown("a")){
            Vector3 left = new Vector3(0,0,1);
            rb.velocity = left * leftSpeed;
        }
        if(Input.GetKeyDown("d")){
            Vector3 right = new Vector3(0,0,-1);
            rb.velocity = right * rightSpeed;
        }
        
    }
}
