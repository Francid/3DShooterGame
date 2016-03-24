using UnityEngine;
using System.Collections;

public class KeyController : MonoBehaviour {

	//PUBLIC VARIABLES
	public GameController gamecontroller;

	//PRIVATE VARIABLES

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	//Check for collision
	void OnTriggerEnter(Collider other){

		if(other.gameObject.CompareTag("Player")){
			Debug.Log ("Collides");
			this.gamecontroller.ScoreValue += 1;
		}
	}
}
