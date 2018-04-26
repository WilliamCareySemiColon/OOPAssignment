using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidController : MonoBehaviour {

    public GameObject prefab;
     public int spin;

    // Instantiate the prefab somewhere between -10.0 and 10.0 on the x-z plane
    void Start()
    {
            Vector3 position = new Vector3(Random.Range(-float.MaxValue % 1000, float.MaxValue % 1000),
                Random.Range(-float.MaxValue % 1000, float.MaxValue % 1000),
                Random.Range(-float.MaxValue % 1000, float.MaxValue % 1000));
            Instantiate(prefab, position, Quaternion.identity);
    }

    private void Update()
    {
        transform.Rotate(15 * (Time.deltaTime* spin), 30 * (Time.deltaTime * spin), 45 * (Time.deltaTime * spin));
    }
}
