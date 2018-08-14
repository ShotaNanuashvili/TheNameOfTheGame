using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSystem : MonoBehaviour {
    private GameObject player;
    public float xMin;
    public float xMax;
    public float yMin;
    public float yMax;

    // Use this for initialization
    void Start () {
        player = GameObject.FindGameObjectWithTag("player");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
