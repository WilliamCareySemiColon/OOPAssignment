using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidController : MonoBehaviour {

    public GameObject prefab;
     public float spin;
    public Rigidbody rigidbody;

    // Instantiate the prefab somewhere between -10.0 and 10.0 on the x-z plane
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();

        rigidbody.angularVelocity = Random.insideUnitSphere * spin;

        /*Vector3 position = new Vector3(Random.Range(-float.MaxValue % 1000, float.MaxValue % 1000),
                Random.Range(-float.MaxValue % 1000, float.MaxValue % 1000),
                Random.Range(-float.MaxValue % 1000, float.MaxValue % 1000));
            Instantiate(prefab, position, Quaternion.identity);*/
    }

}
