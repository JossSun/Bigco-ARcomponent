using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spin1 : MonoBehaviour {
    public float speed = 10f;
    private Vector3 origin = new Vector3 (0.0f, 0.33f, 0.0f);

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.RotateAround(Vector3.zero, Vector3.up, 20 * Time.deltaTime);
    }
}
