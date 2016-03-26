using UnityEngine;
using System.Collections;

/* GAME PROGRAMMING I
 * Source File: EnemyController
 * Author: Francis Ofougwuka
 * Last Modified by: Francis Ofougwuka
 * Date Last Modified: 25/03/2016
 * 
*/

// KeyController Class
public class KeyController : MonoBehaviour {

	//PUBLIC VARIABLES
	public GameController gamecontroller;


	//PRIVATE VARIABLES
	private AudioSource _keySound;

	// Use this for initialization
	void Start () {
		//Initialize the variable
		this._keySound = gameObject.GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	//Check for collision
	void OnTriggerEnter(Collider other){

		//Check if collision is with the player 
		if(other.gameObject.CompareTag("Player")){
			this._keySound.Play ();
			this.gamecontroller.ScoreValue += 1;
			this.gameObject.SetActive (false);

		}
	}
}
