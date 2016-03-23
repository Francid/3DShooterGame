using UnityEngine;
using System.Collections;

public class WallNailController : MonoBehaviour {

	//PUBLIC VARIABLES
	public float speed;
	public float zMin;
	public float zMax;
	public int switchDirection;

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

		if (this._currentPosition.z >= this.zMin) {
			this.switchDirection = 0;
		}

		if (this._currentPosition.z <= this.zMax) {
			this.switchDirection = 1;
		}

		if (this.switchDirection == 0) {
			this._currentPosition -= new Vector3 (0f,0f, speed);
			this._transform.position = this._currentPosition;
		}
		if (this.switchDirection == 1) {
			this._currentPosition += new Vector3 (0f,0f, speed);
			this._transform.position = this._currentPosition;
		}

	}
		
}
