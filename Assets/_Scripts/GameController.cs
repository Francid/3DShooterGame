using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

/* GAME PROGRAMMING I
 * Source File: GameController
 * Author: Francis Ofougwuka
 * Last Modified by: Francis Ofougwuka
 * Date Last Modified: 25/03/2016
 * 
*/

// GameController Class
public class GameController : MonoBehaviour {
	
	// PRIVATE INSTANCE VARIABLES
	private int _scoreValue;
	private int _livesValue;
	private AudioSource[] _audioSources;
	private AudioSource _gameSound;
	private AudioSource _gameOverSound;
	private AudioListener _gameOverListener;


	// PUBLIC ACCESS METHODS
	public int ScoreValue {
		get {
			return this._scoreValue;
		}

		set {
			this._scoreValue = value;
			this.ScoreLabel.text = "Key: " + this._scoreValue;
		}
	}

	public int LivesValue {
		get {
			return this._livesValue;
		}

		set {
			this._livesValue = value;
			if (this._livesValue <= 0) {
				this._endGame ();
			} else {
				this.LivesLabel.text = "Lives: " + this._livesValue;
			}
		}
	}
		
	// PUBLIC INSTANCE VARIABLES
	public Text LivesLabel;
	public Text ScoreLabel;
	public Text GameOverLabel;
	public Text PointScoreLabel;
	public Button RestartButton;
	public GameObject player;

	// Use this for initialization
	void Start () {
		this._initialize ();

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	//PRIVATE METHODS ++++++++++++++++++

	//Initial Method
	private void _initialize() {
		this.ScoreValue = 0;
		this.LivesValue = 5;
		this.GameOverLabel.gameObject.SetActive (false);
		this.PointScoreLabel.gameObject.SetActive (false);
		this.RestartButton.gameObject.SetActive(false);

		this._gameOverListener = gameObject.GetComponent<AudioListener> ();
		this._audioSources = gameObject.GetComponents<AudioSource> ();
		this._gameSound = this._audioSources [0];
		this._gameOverSound = this._audioSources [1];

		this._gameSound.Play ();

	}

	private void _endGame() {
		this.PointScoreLabel.text = "Point Score: " + (this._scoreValue * 20);
		this.GameOverLabel.gameObject.SetActive (true);
		this.PointScoreLabel.gameObject.SetActive (true);
		this.RestartButton.gameObject.SetActive (true);
		this.LivesLabel.gameObject.SetActive (false);
		this.ScoreLabel.gameObject.SetActive (false);
		this.player.gameObject.SetActive (false);
		this._gameOverListener.enabled = true;
		this._gameSound.Stop ();
		this._gameOverSound.Play ();
	}

	// PUBLIC METHODS

	public void ResetButtonClick() {
		SceneManager.LoadScene (SceneManager.GetActiveScene().name);
	}
}
