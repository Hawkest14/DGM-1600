using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrays : MonoBehaviour {

	public string[] heros = new string[6];


	// Use this for initialization
	void Start () {
	heros[0] = "Link";
	heros[1] = "Gibbs";
	heros[2] = "Sgt. Johnson";
	heros[3] = "Master Chief";
	heros[4] = "Ezio";
	heros[5] = "soap";
	
	print(heros[0]);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
