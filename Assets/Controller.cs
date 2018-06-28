using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour {

	public bool IsGrounded = false;
	public GameObject RotorMain;
	public GameObject RotorRear;

	int RotorSpeed = 800;

	// Use this for initialization
	void Start () {
		RotorMain = GameObject.Find("Rotor");

	}
	
	// Update is called once per frame
	void Update () {
		RotorMain.transform.Rotate(new Vector3(0,0,1) * RotorSpeed * Time.deltaTime);

		/*if(Input.GetKey (KeyCode.LeftShift))
			{
				RotorSpeed += 10;
				RotorSpeed = Mathf.Clamp (RotorSpeed, 800, 1200);
			transform.Translate(new Vector3(0,1,0) * 2 * Time.deltaTime);

			}
		if(Input.GetKey (KeyCode.LeftControl))
		{
			RotorSpeed -= 10;
			RotorSpeed = Mathf.Clamp (RotorSpeed, 800, 1200);
			transform.Translate(-new Vector3(0,1,0) * 2 * Time.deltaTime);

		}

		if (!IsGrounded) 
		{
			transform.Rotate (Vector3.up * Input.GetAxis ("Horizontal") * Time.deltaTime * RotorSpeed / 10);
			transform.Translate (-Vector3.forward * Input.GetAxis ("Vertical") * Time.deltaTime * RotorSpeed / 100);
		}*/
	}
}
