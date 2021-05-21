using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coin : MonoBehaviour
{
    public GameObject Player;
    int coin = 10;
    int sum;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player"){
           Destroy(gameObject);

           sum = sum + coin;
           GameObject.FindWithTag("Counter").GetComponent<Text>().text = sum.ToString();
           
        }
    }
}
