using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ListManager : MonoBehaviour {

	public GameObject Player;
	public GameObject TextArea;

	private ArrayList taskList;

	// Use this for initialization
	void Start () {
		taskList = new ArrayList();
	}
	
	// Update is called once per frame
	void Update () {
		if (!Player.GetComponent<PlayerController> ().target && taskList.Count > 0) {
			Player.GetComponent<PlayerController> ().target = ((GameObject)taskList [0]).GetComponent<StationController>().GetAccessPosition();
		}
	}

	public void AddElement(string text) {
		TextArea.GetComponent<Text>().text = "asdad";
	}

	public void WasClicked(GameObject Target) {
		taskList.Add(Target);

		string newText = "";
		foreach (GameObject go in taskList) {
			newText += go.name + "\n";
		}

		TextArea.GetComponent<Text>().text = newText;
	}

	public void ReachedTarget(GameObject Target) {
		Debug.Log ("player reached " + Target.name);
		taskList.RemoveAt (0);
	}
}
