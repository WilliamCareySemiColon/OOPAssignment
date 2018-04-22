using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereMover : MonoBehaviour {

    public Rigidbody rigidbody;
    public float speed;

    private void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }
    private void FixedUpdate()
    {
        float moveVertical = Input.GetAxis("Vertical");
        float moveHonrizontal = Input.GetAxis("Horizontal");

        Vector3 movement = new Vector3(moveHonrizontal, 0.0f, moveVertical);

        rigidbody.AddForce(movement * speed);
    }
}
