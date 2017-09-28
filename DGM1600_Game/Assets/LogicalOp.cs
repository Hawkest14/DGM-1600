using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicalOp : MonoBehaviour {
	public string luke = "jedi";

	public string vader = "sith";

	public bool leia = true;

	public string darkSide = "Darth Maul";

	public string lightSide = "Obi Wan";

	public int num1 = 10;

	public float num2 = 10.5f;



	// Use this for initialization
	void Start () {
	// 	if(luke == "jedi"&& vader == "Nanny"){
	// 		print("Vaders your Nanny!");
	// 	}
	// 	else if (luke == "Jawa"&& vader == "sith"){
	// 		print("Utini");
	// 	}
	// 	else if(luke == "jedi"&& vader == "sith"){
	// 		print("Noooooooooooooooo! That's not true.... That's imposible!");
	// 	}
	// 	}
	// }

	// if(leia){
	// 	print("No, there is another.");
	// 	}
	// else if(!leia){
	// 		print("Mesa Ja Ja Binks.");
	// 	}
	// else 
	// 	print("Hans shot first.");
	// if(lightSide == "Obi Wan" || darkSide == "Jar Jar Binks"){
	// 	print("Meeeza Evil Bad Bad Lorda");
	
	// }
	// else if(lightSide == "Boba Fett" || darkSide == "Darth Maul"){
	// 	print("As you wish, my Master");
	// }
	// else{
	// 	print("Yousa in bad doo doo tis time.");
	// }
	if(num1 == 10 && num2 == 10.5){
		print("Thing King");
	}
	else if (num1 == 10 || num2 == 10){
		print("Chocolate Thunder!");
	}
	else{
		print("Ben");
	}
}
	

	// Update is called once per frame
	void Update () {
		
	}
}