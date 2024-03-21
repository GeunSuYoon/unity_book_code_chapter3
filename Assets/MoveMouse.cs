using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveMouse : MonoBehaviour
{
	Transform	tr;
	Vector2		mousePosition;

    // Start is called before the first frame update
    void Start()
    {
        tr = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
		{
			mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			// Object move to mouse pointer
			// Speed is related with 3rd parameter.
			// 3rd parameter is bigger, speed will be faster
			tr.position = Vector2.MoveTowards(tr.position, mousePosition, Time.deltaTime * 5f);
		}
    }
}
