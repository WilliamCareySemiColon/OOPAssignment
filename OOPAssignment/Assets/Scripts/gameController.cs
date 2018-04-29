using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameController : MonoBehaviour
{

    public GameObject hazards;
    public GameObject player;
    private List<GameObject> allHazards = new List<GameObject>();

    public float maxArea; 
    public int num;  
    private static int asteroidCount = 0;

    private void Start()
    {
        spawnHazards();
        allHazards.Add(player);

    }

    private void LateUpdate()
    {
        for(int x = 0; x < allHazards.Count; x++)
        {
            if (allHazards[x].transform.position.x > maxArea)
                allHazards[x].transform.position = new Vector3(maxArea, 
                    allHazards[x].transform.position.y, allHazards[x].transform.position.z);

            if (allHazards[x].transform.position.y > maxArea)
                allHazards[x].transform.position = new Vector3(allHazards[x].transform.position.x,
                    maxArea, allHazards[x].transform.position.z);

            if (allHazards[x].transform.position.z > maxArea)
                allHazards[x].transform.position = new Vector3(allHazards[x].transform.position.x,
                    allHazards[x].transform.position.y, maxArea);

            if (allHazards[x].transform.position.x < -maxArea)
                allHazards[x].transform.position = new Vector3(-maxArea,
                    allHazards[x].transform.position.y, allHazards[x].transform.position.z);

            if (allHazards[x].transform.position.y < -maxArea)
                allHazards[x].transform.position = new Vector3(allHazards[x].transform.position.x,
                    -maxArea, allHazards[x].transform.position.z);

            if (allHazards[x].transform.position.z < -maxArea)
                allHazards[x].transform.position = new Vector3(allHazards[x].transform.position.x,
                    allHazards[x].transform.position.y, -maxArea);
        }
    }
    void spawnHazards()
    {
        while (asteroidCount != num)
        {
            build();

            asteroidCount++;
        }
    }

    public void build()
    {
        Vector3 spawnPosition = player.transform.position + returnPosition();

        Quaternion spawnRotation = Quaternion.identity;

        allHazards.Add(Instantiate(hazards, spawnPosition, spawnRotation));
    }

    private Vector3 returnPosition()
    {
        int random = Random.Range(0, 999) % 3;

        switch(random)
        {
            case 0:
                return new Vector3(posCheckAreaForSpawn(), negCheckAreaForSpawn(), 0);
            case 1:
                return new Vector3(0, posCheckAreaForSpawn(), negCheckAreaForSpawn());
            default:
                return new Vector3(negCheckAreaForSpawn(), 0, posCheckAreaForSpawn());
        }
    }

    private float negCheckAreaForSpawn()
    {
        
        return -Random.Range(0,maxArea);
    }

    private float posCheckAreaForSpawn()
    {

        return Random.Range(0, maxArea);
    }
}

