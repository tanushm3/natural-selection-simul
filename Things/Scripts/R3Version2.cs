using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class R3Version2 : Reprod2 {

	public float timeforNewFood = 5.0f;
	float time1 = 0.0f;
	public int rEtouched = 0;

	void Update(){
		if (rEtouched != 1) {
			rEtouched = touchy;
		}
		rEtouched = touched;
		float time2 = Time.time;

		if (time2 > 7.0f) {

			if (time2 - time1> timeforNewFood+5.0f) {
				//print ("Objext");
				if (rEtouched == 1) {

					Destroy (gameObject);
					print ("Objexxt");

				}
			}	
		}
	}
}
