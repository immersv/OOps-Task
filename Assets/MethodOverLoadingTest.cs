using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MethodOverLoadingTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        TestPrint();
    }
    void TestPrint()
    {
        Debug.Log("Method without Parameter");
    }
    void TestPrint(int i)
    {
        Debug.Log("Method with int parameter");
    }
    void TestPrint(float i)
    {
        Debug.Log("Method with float parameter");
    }
}
