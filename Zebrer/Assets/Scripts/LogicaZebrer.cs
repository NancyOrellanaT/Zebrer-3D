using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicaZebrer : MonoBehaviour {

    private Transform position;
    private double coordenadaX;
    private double coordenadaY;
    private double coordenadaZ;

	// Use this for initialization
	void Start () {
        position = GetComponent<Transform>();
    }
	
	// Update is called once per frame
	void Update () {
        position.transform.position += new Vector3(-0.5f, 0, 0);

	}
}
