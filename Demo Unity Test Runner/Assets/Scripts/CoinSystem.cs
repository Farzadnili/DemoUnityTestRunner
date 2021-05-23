using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinSystem : MonoBehaviour
{
    //int coin = 10;
    public Text summ;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player"){
         Destroy(gameObject);
         addCoin(10);
        }
    }
    public void addCoin(int coin){
        Coin.sum += coin;   
        summ.text = Coin.sum.ToString();
        GameObject.FindWithTag("sumCoin").GetComponent<Text>().text = summ.text;
   } 
    
}
