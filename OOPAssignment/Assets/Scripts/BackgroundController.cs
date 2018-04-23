using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundController : MonoBehaviour {

    public Material [] background;

    void Start()
    {
        background = Resources.LoadAll<Material>("");
    }
    // Update is called once per frame
    void Update () {
        RenderSettings.skybox = background[3];
		
	}
}
