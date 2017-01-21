using UnityEngine;

public class BlackHole : MonoBehaviour {

    public float pullForce;
    public SphereCollider circleCollider;

    float _radius;

	// Use this for initialization
	void Start () {

        _radius = circleCollider.radius;
	}

    void OnTriggerStay(Collider other){

        if (!other.CompareTag(Tags.Bullet)) return;

        Vector2 direction = transform.position - other.transform.position;

        Debug.DrawRay(transform.position, direction, Color.red);

        //Final force increases linearly if the bullet is closer to the Black Hole's center
        var finalPullForce = pullForce * (_radius - direction.magnitude) / _radius;
        finalPullForce = Mathf.Abs(finalPullForce);

        var bulletRigidbody = other.GetComponent<Rigidbody>();
        bulletRigidbody.AddForce(direction.normalized * finalPullForce);
    }
}
