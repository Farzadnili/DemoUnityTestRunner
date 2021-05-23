using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.TestTools;

public class CoinTest
{
    // A Test behaves as an ordinary method
    [Test]
    public void CoinTest1()
    {
      //Arrange
      var Coinn = GameObject.FindWithTag("Coin").GetComponent<CoinSystem>();
      //Act
      Coinn.addCoin(10);
      //Assert
      Assert.AreEqual("10", GameObject.FindWithTag("sumCoin").GetComponent<Text>().text);
       }
       //[Test]
    // public void CoinTest2()
    // {
    //   //Arrange
    //   var Coinn = GameObject.FindWithTag("Coin").GetComponent<CoinSystem>();
    //   //Act
    //   Coinn.addCoin(100);
    
    //   //Assert
    //   Assert.AreEqual("100", GameObject.FindWithTag("sumCoin").GetComponent<Text>().text);
    //    }
}
