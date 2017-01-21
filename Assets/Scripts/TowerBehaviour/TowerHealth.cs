using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TowerHealth : MonoBehaviour {

    public delegate void TowerEvent(int playerNumber);
    public static event TowerEvent OnTowerDestroyed;

    public Image[] heartImages;
    public int playerNumber;

    int _currentLife;

	// Use this for initialization
	void Start () {

        _currentLife = heartImages.Length - 1;
	}

    void OnTriggerEnter(Collider other){

        if (!other.CompareTag(Tags.Bullet)) return;

        heartImages[_currentLife].color = heartImages[_currentLife].color.NewColor(0.2f);
        _currentLife--;

        if(_currentLife == 0){
            if (OnTowerDestroyed != null) OnTowerDestroyed(playerNumber);
        }
    }
}
