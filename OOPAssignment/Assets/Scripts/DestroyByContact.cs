using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByContact : MonoBehaviour {

    public GameObject explosion;
    public GameObject playerExplosion;

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Bullets" || other.tag == "SpaceShip")
        {
            Instantiate(explosion, transform.position, transform.rotation);

            if(other.tag == "SpaceShip")
            {
               Instantiate(playerExplosion, other.transform.position, other.transform.rotation);
            }
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
}