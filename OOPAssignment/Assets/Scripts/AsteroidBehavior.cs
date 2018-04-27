using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidBehavior : MonoBehaviour {

    public float tumble;
    public Rigidbody rigidbody;
    private float x;

    // Use this for initialization
    void Start () {
        rigidbody = GetComponent<Rigidbody>();
        rigidbody.angularVelocity = Random.insideUnitSphere * tumble;
        transform.localScale = new Vector3(x = Random.Range(1, 4), x, x);

        transform.Rotate(new Vector3(Random.Range(0, 359), Random.Range(0, 359), Random.Range(0, 359)));
    }
}
