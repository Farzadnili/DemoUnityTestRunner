using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    Rigidbody rb;
    public float JumpHigh;
    public Terrain terrain;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
       if(Input.GetKeyDown("j")){
            Vector3 jump = new Vector3(0,JumpHigh,0); 
            rb.AddForce(jump);
        }
    }

    //  void OnTriggerEnter(Collider other)
    // {
    //     if(other.tag == "Terrain" && Input.GetKeyDown("j")){
    //         Vector3 jump = new Vector3(0,JumpHigh,0); 
    //         rb.AddForce(jump);
    //     }
    // }

}