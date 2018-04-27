using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMover : MonoBehaviour {

    public float speed;
    public float destroyThis;
    public Rigidbody rigidbody;

	// Use this for initialization
	void Start () {

        rigidbody = GetComponent<Rigidbody>();

        rigidbody.velocity = transform.forward * speed;
	}

    private void Update()
    {
        Destroy(gameObject, destroyThis);
    }
}
