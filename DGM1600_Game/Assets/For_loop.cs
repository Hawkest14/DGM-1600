using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class For_loop : MonoBehaviour {
	// public int bottles = 100;
	// Use this for initialization
	void Start () {
		// while(bottles > 0){
		// 	print(bottles+" of sprite on the wall ");
		// 	bottles --;
		// }
		for(int bottles = 100; bottles > 0; bottles --){
			print(bottles + " bottles of dew on the wall");
		}
		for(int tanks = 100; tanks > 0; tanks --){
			print(tanks + " Tanks left!");
		}
		for(int planes = 150; planes > 0; planes --){
			print(planes + " Planes left!");
		}
		for(int infantry = 1500; infantry > 0; infantry --){
			print(infantry + " Man Down!");
		}
		for(int panzers = 0; panzers < 200; panzers ++){
			print(panzers + " destroyed!");
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
