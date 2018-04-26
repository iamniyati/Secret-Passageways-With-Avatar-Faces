using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class Position : MonoBehaviour {

    public GameObject right;
    public GameObject left;
    public GameObject center;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        right.transform.position = new Vector3(25f, 3f, 9f);

    }
}
