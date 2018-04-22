using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehavour : MonoBehaviour {

    //taking the players location and placing the camera behind it, with the ability to follow it
    public GameObject player;
    private Vector3 offset;

    // Use this for initialization
    void Start()
    {
        offset = transform.position - player.transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}
