using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerMovement : MonoBehaviour {

	public GameObject tower_player01;
	public GameObject tower_player02;

	private float speedPlayer01;
	private float speedPlayer02;

	void Start () {
		speedPlayer01 = Random.Range(10f, 25.0f);
		speedPlayer02 = Random.Range(10f, 25.0f);
	}

	void Update () {
		tower_player01.transform.rotation = Quaternion.Euler (0, 0, -Mathf.PingPong (Time.time * speedPlayer01, 85));
		tower_player02.transform.rotation = Quaternion.Euler (0, 0,  Mathf.PingPong (Time.time * speedPlayer02, 85));
	}
}
