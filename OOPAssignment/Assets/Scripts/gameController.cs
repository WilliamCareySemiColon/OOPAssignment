using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameController : MonoBehaviour {

   public GameObject hazards;
   public GameObject player;
   public int num;

    private static int asteroidCount = 0;

    private void Start()
    {
        spawnHazards();
    }

    void spawnHazards()
    {
        while (asteroidCount != num)
        {
            build();

            asteroidCount++;
        }
    }

    private Vector3 returnPosition()
    {
        int random = Random.Range(0, 999) % 3;

        switch(random)
        {
            case 0:
                return new Vector3(Random.Range(20, (num > 20 ? num: 30)), -Random.Range(20, (num > 20 ? num : 30)), 0);
            case 1:
                return new Vector3(0, Random.Range(20, (num > 20 ? num : 30)), -Random.Range(20, (num > 20 ? num : 30)));
            default:
                return new Vector3(-Random.Range(20, (num > 20 ? num : 30)), 0, Random.Range(20, (num > 20 ? num : 30)));
        }
    }

     public void build()
    {
        Vector3 spawnPosition = player.transform.position + returnPosition();

        Quaternion spawnRotation = Quaternion.identity;

        Instantiate(hazards, spawnPosition, spawnRotation);
    }
}

