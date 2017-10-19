using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vehicle_Movement : MonoBehaviour {

	public GameObject car;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void goForward(){
		Vector3 mov = new Vector3 (0.2f, 0.0f, 0.0f);
		car.transform.Translate (mov*Time.deltaTime);
	}
}
