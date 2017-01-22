using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

	public GameObject vfxObj;
	public Renderer mRenderer;

    Rigidbody _rigidbody;

	// Use this for initialization
	void Start () {

        _rigidbody = GetComponent<Rigidbody>();
	}

    void FixedUpdate(){

        transform.rotation = _rigidbody.velocity.Rotate(Vector3.forward, -90).ToRotation();
    }

	public void TriggerExplosion(){
	
		vfxObj.SetActive (true);
		mRenderer.enabled = false;
		_rigidbody.velocity = Vector3.zero;
	}
}
