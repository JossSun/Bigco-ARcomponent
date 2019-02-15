using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spin1 : MonoBehaviour {
    public float speed = 10f;
    public GameObject earth;
    public GameObject cloud1;
    public GameObject cloud2;
    public GameObject cloud3;
    public GameObject cloud4;


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        cloud1.transform.RotateAround(earth.transform.position, earth.transform.up, 7 * Time.deltaTime);
        cloud2.transform.RotateAround(earth.transform.position, earth.transform.up, 5 * Time.deltaTime);
        cloud3.transform.RotateAround(earth.transform.position, earth.transform.up, 2 * Time.deltaTime);
        cloud4.transform.RotateAround(earth.transform.position, earth.transform.up, 5 * Time.deltaTime);
    }
}
