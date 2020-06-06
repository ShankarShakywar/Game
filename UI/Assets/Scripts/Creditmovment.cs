using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Creditmovment : MonoBehaviour
{

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector2.up * 20.0f * Time.deltaTime);
		
	}
}
