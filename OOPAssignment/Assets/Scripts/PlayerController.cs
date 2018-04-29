using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject shot;
    public GameObject hazards;
    public Transform shotSpawn;
    public Transform asteroidSpawn;
    public float rotationSpeed = 150f;
    public float moveSpeed = 10.0f;
    public float nextFire, fireRate;
    public AudioSource audio;


    // Update is called once per frame
    void Update()
    {
        //if we want to fire a bullet
        if ((Input.GetButton("Fire1") || Input.GetKeyDown(KeyCode.Space) && Time.time > nextFire))
        {
            nextFire = Time.time + fireRate;
            Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
            audio.Play();
        }

        //if we want to create a asteroid
        if (Input.GetKey(KeyCode.Return))
        {     
            Instantiate(hazards, asteroidSpawn.position, asteroidSpawn.rotation);
        }

    }

    private void FixedUpdate()
    {
        //move forward faster
        if (Input.GetKey(KeyCode.W) && moveSpeed < 250f)
        {
            moveSpeed += 5;
        }

        //move forward slower
        if (Input.GetKey(KeyCode.S) && moveSpeed > 0f)
        {
            moveSpeed -= 5;
        }

        if (Input.GetKey(KeyCode.E) && moveSpeed > 0)
        {
            //move down
            transform.Rotate(rotationSpeed * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey(KeyCode.Q) && moveSpeed > 0)
        {
            // move up
            transform.Rotate(-rotationSpeed * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey(KeyCode.A))
        {
            // Rotate counterclockwise if the ship is not moving 
            transform.Rotate(0, (-rotationSpeed * Time.deltaTime)/8, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            // Rotate clockwise if the ship is not moving 
            transform.Rotate(0, (rotationSpeed * Time.deltaTime)/8, 0);
        }

        if (Input.GetKey(KeyCode.Z))
        {
            //spin left
            transform.Rotate(0, 0, rotationSpeed * Time.deltaTime);
        }


        if (Input.GetKey(KeyCode.X))
        {
            //spin right
            transform.Rotate(0, 0, -rotationSpeed * Time.deltaTime);
        }

        transform.Translate(0, 0, moveSpeed * Time.deltaTime);

        if (moveSpeed > 500)
            moveSpeed = 500;

        if (moveSpeed < 0)
            moveSpeed = 0;
    }

}   