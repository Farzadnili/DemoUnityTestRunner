using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coin : MonoBehaviour
{
    public GameObject Player;
    public Text text;
    
   public static int sum;

  void Update()
    {
        GameObject.FindWithTag("Counter").GetComponent<Text>().text = sum.ToString();
    }
       
}
