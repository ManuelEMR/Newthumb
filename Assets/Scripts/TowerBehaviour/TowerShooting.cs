using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;

public class TowerShooting : MonoBehaviour {

	public GameObject bullet_emitter01;
	public GameObject bullet_emitter02;

	public GameObject bullet01;
	public GameObject bullet02;

    public float firingRate;

	private float speed = 200;

	void Start() {
		StartCoroutine (BulletGenerator());
	} 

	private IEnumerator BulletGenerator() {
		while (true) {
			yield return new WaitForSeconds (firingRate);

			speed = Mathf.Clamp (speed, 200, 300);

			GameObject Temporary_Bullet_Handler01;
			Temporary_Bullet_Handler01 = Instantiate (bullet01, bullet_emitter01.transform.position,
				bullet_emitter01.transform.up.Rotate(Vector3.forward, -90).ToRotation()) as GameObject;
			Rigidbody temporary_Rigidbody01 = Temporary_Bullet_Handler01.GetComponent<Rigidbody> ();
			temporary_Rigidbody01.AddForce (bullet_emitter01.transform.up * speed);
			Destroy (Temporary_Bullet_Handler01, 15.0f);

			GameObject Temporary_Bullet_Handler02;
			Temporary_Bullet_Handler02 = Instantiate (bullet02, bullet_emitter02.transform.position,
				bullet_emitter02.transform.up.Rotate(Vector3.forward, -90).ToRotation()) as GameObject;
			Rigidbody temporary_Rigidbody02 = Temporary_Bullet_Handler02.GetComponent<Rigidbody> ();
			temporary_Rigidbody02.AddForce (bullet_emitter02.transform.up * speed);
			Destroy (Temporary_Bullet_Handler02, 15.0f);

			speed += 0.5f;
		}
	}
}
