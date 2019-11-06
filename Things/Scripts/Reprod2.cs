using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Reprod2 : R1 {





	//void Update(){}
	public GameObject player;
	//public int touched = 1;

	public int reprodVar = 0;
	public GameObject newPreFab;
	public int touchy;



	void OnTriggerEnter(Collider target){

		touchy = touched;
		if(target.tag == "Food") {
			print ("Touched");
			touchy = 0;
			reprodVar += 1;
			if (reprodVar % 2 == 0) {
				
				print ("Touched two times");
				Instantiate(newPreFab,gameObject.transform.position,Quaternion.identity);
				reprodVar = 0;
			}
		}
	

	}




}