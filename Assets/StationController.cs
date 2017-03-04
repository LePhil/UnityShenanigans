using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StationController : MonoBehaviour {

	public string Name;
	private GameObject Manager;

	// Use this for initialization
	void Start () {
		Manager = GameObject.Find ("ListManager");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnMouseDown() {
		Debug.Log ("click on " + Name + " (" + name + ")");

		Manager.SendMessage ("WasClicked", this.gameObject);
	}

	public GameObject GetAccessPosition() {
		return (GameObject)transform.GetChild (1).gameObject;
	}
}
