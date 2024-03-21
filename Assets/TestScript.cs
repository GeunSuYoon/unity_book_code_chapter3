using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
		int	a = 10;
		int	b = 5;

        Debug.Log("a = " + a);
        Debug.Log("a + b = " + (a + b));
        Debug.Log("a - b = " + (a - b));
        Debug.Log("a * b = " + (a * b));
        Debug.Log("a / b = " + (a / b));
        Debug.Log("int a / 3 = " + (a / 3));
        Debug.Log("float a / 3 = " + ((float)a / 3));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
