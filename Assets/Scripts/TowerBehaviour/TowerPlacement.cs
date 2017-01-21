using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerPlacement : MonoBehaviour {

	public Transform playerOneTower;
	public Transform playerTwoTower;
	public Vector3 playerOneOffset;
	public Vector3 playerTwoOffset;

	// Use this for initialization
	void Start () {

		Vector3 leftSide = Camera.main.ViewportToWorldPoint (new Vector3 (0, 0, 0));
		Vector3 rightSide = Camera.main.ViewportToWorldPoint (new Vector3 (1, 0, 0));

		leftSide.Set (leftSide.x, leftSide.y, 0);
		rightSide.Set (rightSide.x, rightSide.y, 0);

		playerOneTower.position = leftSide + playerOneOffset;
		playerTwoTower.position = rightSide + playerTwoOffset;
	}
}
