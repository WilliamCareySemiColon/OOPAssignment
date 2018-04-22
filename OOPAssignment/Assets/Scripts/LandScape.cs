using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LandScape : MonoBehaviour
{
    public float squareArea;
	// Use this for initialization
	void Start ()
    {
        transform.position.Set(0, 0, 0);
        
        transform.localScale = new Vector3(squareArea, 1, squareArea);
	}
}
