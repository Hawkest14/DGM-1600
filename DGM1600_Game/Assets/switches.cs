using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class switches : MonoBehaviour {
	public string townCenter = "main";
	
	// Use this for initialization
	void Start () {
		switch(townCenter){
			case "main":
				print("Welcome to Main Street");
			break;
			case "blacksmith":
				print("The blacksmith grumbles as you pick through the sword bin");
			break;
			case "bakery":
				print("Mmmmmmmmmmm baked goodness.");
			break;
			case "pub":
				print("And don't ever show your face in this pub again! Welcome traveler.");
			break;
			default:
				print("I don't know what you are talking about.");
			break;
		
		}



	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
