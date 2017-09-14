using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class conditional : MonoBehaviour {

public string stopLight = "Red";

void start(){
	Main();
}
void Main(){
	if(stopLight == "Red"){
	print("STOP! Tht light is Red!");
	}
	else if (stopLight == "Yellow" ){
		print("Slow Down!");
	}
	else if (stopLight == "Green" ){
		print("Green means GO!");
	}
	else{
		print("I Dont know what you mean!");
	}


}

}
