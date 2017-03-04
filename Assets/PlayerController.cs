using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public float speed = 1.0f;
	public GameObject target;
	public GameObject Manager;

	// Use this for initialization
	void Start () {
		Manager = GameObject.Find ("ListManager");

	}

	
	// Update is called once per frame
	void Update () {
		if (target) {
			float step = speed * Time.deltaTime;
			transform.position = Vector3.MoveTowards (transform.position, target.transform.position, step);
		}
	}


	void OnTriggerEnter (Collider col) {
		Debug.Log ("collision detected " + col.gameObject.name);
		if(col.gameObject == target)
		{
			target = null;
			Manager.SendMessage ("ReachedTarget", col.gameObject);
		}
	}


}
