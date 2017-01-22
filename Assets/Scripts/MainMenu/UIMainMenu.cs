using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIMainMenu : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	public void LoadGame(){
	
		//Level 1
		SceneManager.LoadScene (1);
	}
}
