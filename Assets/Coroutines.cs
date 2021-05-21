using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Coroutines : MonoBehaviour
{


    private void Awake()
    {
        
    }
    private void Start()
    {
        StartCoroutine("ColorTest");
        ColorsTest();
    }
    IEnumerator ColorTest()
    {
        print("Start of Corotine");
       // yield return new WaitForSeconds(2.0f);
        GetComponent<Renderer>().material.color = Color.red;
       // yield return new WaitForSeconds(2.0f);
        GetComponent<Renderer>().material.color = Color.green;
        yield return null;//wait for end of frame
        print("End of Corutine");
    }
    void ColorsTest()
    {
        print("Start of normal function");
        
        GetComponent<Renderer>().material.color = Color.red;
      
        GetComponent<Renderer>().material.color = Color.green;
       
        print("End of Normal function");
    }
}
