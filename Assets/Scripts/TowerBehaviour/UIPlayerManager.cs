using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIPlayerManager : MonoBehaviour {

	public GameObject playerOneWon;
	public GameObject playerTwoWon;

	Image _image;

	// Use this for initialization
	void Start () {

		_image = GetComponent<Image> ();

		TowerHealth.OnTowerDestroyed += OnPlayerWon;
	}

	void OnDestroy(){

		TowerHealth.OnTowerDestroyed -= OnPlayerWon;
	}
	
	void OnPlayerWon(int playerNumber){

		_image.color = _image.color.NewColor (1);

		if (playerNumber == 2)
			playerOneWon.SetActive (true);
		else
			playerTwoWon.SetActive (true);

		this.InvokeAfterSeconds (2, () => {

			//Return to Home scene
			SceneManager.LoadScene(0);
		});
	}
}
