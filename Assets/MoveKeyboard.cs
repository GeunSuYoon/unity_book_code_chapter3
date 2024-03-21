using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveKeyboard : MonoBehaviour
{
	Transform	tr;
    // Start is called before the first frame update
    void Start()
    {
        tr = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
			tr.position = new Vector2(tr.position.x + 0.01f, tr.position.y);
		if (Input.GetKey(KeyCode.LeftArrow))
			tr.position = new Vector2(tr.position.x - 0.01f, tr.position.y);
		if (Input.GetKey(KeyCode.UpArrow))
			tr.position = new Vector2(tr.position.x, tr.position.y + 0.01f);
		if (Input.GetKey(KeyCode.DownArrow))
			tr.position = new Vector2(tr.position.x, tr.position.y - 0.01f);
		// float	x = Input.GetAxis("Horizontal") * 0.01f;
		// float	y = Input.GetAxis("Vertical") * 0.01f;
		
		// tr.Translate(new Vector2(x, y));
	}
	
	// Use Translate method.
	// Move more smooth!
		// float	x = Input.GetAxis("Horizontal") * 0.01f;
		// float	y = Input.GetAxis("Vertical") * 0.01f;

		// tr.Translate(new Vector2(x, y));

	// Not use Translate method.
	// Move less smooth!
        // if (Input.GetKey(KeyCode.RightArrow))
		// 	tr.position = new Vector2(tr.position.x + 0.01f, tr.position.y);
		// if (Input.GetKey(KeyCode.LeftArrow))
		// 	tr.position = new Vector2(tr.position.x - 0.01f, tr.position.y);
		// if (Input.GetKey(KeyCode.UpArrow))
		// 	tr.position = new Vector2(tr.position.x, tr.position.y + 0.01f);
		// if (Input.GetKey(KeyCode.DownArrow))
		// 	tr.position = new Vector2(tr.position.x, tr.position.y - 0.01f);
}
