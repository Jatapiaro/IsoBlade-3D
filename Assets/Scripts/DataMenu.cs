using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataMenu : MonoBehaviour {

	DataMenuMaster master;
	// Use this for initialization
	void Start () {
		master = GameObject.FindGameObjectWithTag("GameController").GetComponent<DataMenuMaster>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnMouseDown(){
		if (!master.menuOpen) {
			master.menuOpen = true;
		}
	}
}
