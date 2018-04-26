using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject shot;
    public Transform shotSpawn;
    public float rotationSpeed = 150f;
    public float moveSpeed = 20.0f;
    public float nextFire, fireRate;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && Time.time > nextFire)
        {
            Fire();

            //Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
        }

        if (Input.GetKey(KeyCode.W) && moveSpeed < 500f)
        {
            moveSpeed += 50;
        }

        if (Input.GetKey(KeyCode.S) && moveSpeed > 0f)
        {
            moveSpeed -= 50;
        }

        if (Input.GetKey(KeyCode.A))
        {
            // Rotate counterclockwise
            transform.Rotate(0, -rotationSpeed * Time.deltaTime, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            // Rotate clockwise
            transform.Rotate(0, rotationSpeed * Time.deltaTime, 0);
        }
        if (Input.GetKey(KeyCode.E))
        {
            //move down
            transform.Rotate(rotationSpeed * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey(KeyCode.Q))
        {
            // move up
            transform.Rotate(-rotationSpeed * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey(KeyCode.Z))
        {
            //spin left
            transform.Rotate(0,0, rotationSpeed * Time.deltaTime);
        }


        if (Input.GetKey(KeyCode.X))
        {
            //spin right
            transform.Rotate(0, 0, -rotationSpeed * Time.deltaTime);
        }

        transform.Translate(0, 0, moveSpeed * Time.deltaTime);
    }

    private void FixedUpdate()
    {
        if (moveSpeed > 500)
            moveSpeed = 500;

        if (moveSpeed < 0)
            moveSpeed = 0;
    }

    void Fire()
    {
        // Create the Bullet from the Bullet Prefab
        var bullet = (GameObject)Instantiate(
            shot,
            shotSpawn.position,
            shotSpawn.rotation);

        bullet.transform.Rotate(90, 0, 0);

        // Add velocity to the bullet
        bullet.GetComponent<Rigidbody>().velocity = bullet.transform.forward * (moveSpeed*2);

        // Destroy the bullet after 2 seconds
        Destroy(bullet, 2.0f);
    }
}   