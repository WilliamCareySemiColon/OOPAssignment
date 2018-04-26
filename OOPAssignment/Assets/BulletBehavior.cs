using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehavior : MonoBehaviour {

    public float speed;

    public Rigidbody rigidbody;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        //transform.Translate(0, speed * Time.deltaTime, 0);
        //this.volic transform.forward * (speed * 2);
    }
}