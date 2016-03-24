using UnityEngine;
using System.Collections;

public class WallNailController : MonoBehaviour {

	//PUBLIC VARIABLES
	public float speedx;
	public float speedy;
	public float speedz;
	public float zMin;
	public float zMax;
	public int switchDirection;
	public GameController gamecontroller;

	//PRIVATE VARIABLES
	private Transform _transform;
	private Vector3 _currentPosition;


	// Use this for initialization
	void Start () {

		this._transform = gameObject.GetComponent<Transform> ();
	}
	
	// Update is called once per frame
	void Update () {

		this._currentPosition = this._transform.position;

		if (this.speedx != 0) {
			if (this._currentPosition.x >= this.zMin) {
				this.switchDirection = 0;
			}

			if (this._currentPosition.x <= this.zMax) {
				this.switchDirection = 1;
			}
		}

		if (this.speedy != 0) {
			if (this._currentPosition.y >= this.zMin) {
				this.switchDirection = 0;
			}

			if (this._currentPosition.y <= this.zMax) {
				this.switchDirection = 1;
			}
		}

		if (this.speedz != 0) {
			if (this._currentPosition.z >= this.zMin) {
				this.switchDirection = 0;
			}

			if (this._currentPosition.z <= this.zMax) {
				this.switchDirection = 1;
			}
		}

		if (this.switchDirection == 0) {
			this._currentPosition -= new Vector3 (this.speedx,this.speedy, this.speedz);
			this._transform.position = this._currentPosition;
		}
		if (this.switchDirection == 1) {
			this._currentPosition += new Vector3 (this.speedx,this.speedy, this.speedz);
			this._transform.position = this._currentPosition;
		}

	} // End Update

	//Check for collision
	void OnCollisionEnter(Collision other){

		if(other.gameObject.CompareTag("Player")){
			this.gamecontroller.LivesValue -= 1;
		}
	}
		
}
