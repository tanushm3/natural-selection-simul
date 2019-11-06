/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class R3 : Reprod2 {

	public float timeforNewFood = 5.0f;
	float time1 = 0.0f;
	public int touchyVar;

	void Update(){
		float time2 = Time.time;
		touchyVar = touched;
		if (time2 > 7.0f) {
			
			if (time2 - time1> timeforNewFood+5.0f) {
				//print ("Objext");
				if (touchyVar) {

					Destroy (gameObject);
					print ("Objexxt");

				}
			}	
		}
	}

}
*/