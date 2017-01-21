using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;

public class TowerShooting : MonoBehaviour {

	public GameObject bullet_emitter01;
	public GameObject bullet_emitter02;

	public GameObject bullet01;
	public GameObject bullet02;

	private float speed = 200;

	void Start() {
		StartCoroutine (BulletGenerator());
	} 

	private IEnumerator BulletGenerator() {
		while (true) {
			yield return new WaitForSeconds (0.75f);

			GameObject Temporary_Bullet_Handler01;
			Temporary_Bullet_Handler01 = Instantiate (bullet01, bullet_emitter01.transform.position, bullet_emitter01.transform.rotation) as GameObject;
			Rigidbody temporary_Rigidbody01 = Temporary_Bullet_Handler01.GetComponent<Rigidbody> ();
			temporary_Rigidbody01.AddForce (bullet_emitter01.transform.up * speed);
			Destroy (Temporary_Bullet_Handler01, 30.0f);

			GameObject Temporary_Bullet_Handler02;
			Temporary_Bullet_Handler02 = Instantiate (bullet02, bullet_emitter02.transform.position, bullet_emitter02.transform.rotation) as GameObject;
			Rigidbody temporary_Rigidbody02 = Temporary_Bullet_Handler02.GetComponent<Rigidbody> ();
			temporary_Rigidbody02.AddForce (bullet_emitter02.transform.up * speed);
			Destroy (Temporary_Bullet_Handler02, 30.0f);
		}
	}
}
