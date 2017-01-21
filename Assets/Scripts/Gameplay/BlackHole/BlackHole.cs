using UnityEngine;

public class BlackHole : MonoBehaviour {

    public float pullForce;
    public CircleCollider2D circleCollider;

    float _radius;

	// Use this for initialization
	void Start () {

        _radius = circleCollider.radius;
	}

    void OnTriggerStay2D(Collider2D other){

        if (!other.CompareTag(Tags.Bullet)) return;

        Vector2 direction = transform.position - other.transform.position;

        //Final force increases linearly if the bullet is closer to the Black Hole's center
        var finalPullForce = pullForce * (_radius - direction.magnitude) / _radius;


        var bulletRigidbody = other.GetComponent<Rigidbody2D>();
        bulletRigidbody.AddForce(direction * finalPullForce);
    }
}
