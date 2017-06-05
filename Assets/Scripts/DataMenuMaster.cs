using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataMenuMaster : MonoBehaviour {

	public bool menuOpen;
	public GameObject menu;

	// Use this for initialization
	void Start () {
		menuOpen = false;
		menu = GameObject.FindGameObjectWithTag ("DataInput");
		menu.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		if (menuOpen) {
			menu.SetActive (true);
		}
	}
}
