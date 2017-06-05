using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateBlade : MonoBehaviour {

  	public float Speed = 100;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
   	 transform.Rotate(Vector3.forward * this.Speed * Time.deltaTime);
	}
}
