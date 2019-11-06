using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Reproduce : MonoBehaviour {

	void Update(){
	}


	        public GameObject player;
	        bool touched = true;

	        public int reprodVar = 0;
			public GameObject newPreFab;
			

			
	  	
	     
		void OnTriggerEnter(Collider target){

			if(target.tag == "Food") {
				print ("Touched");
				reprodVar += 1;
				if (reprodVar % 2 == 0) {
					touched = false;
					print ("Touched two times");
					//double pos1 = Random.Range (-10.0f, 10.0f);
					//double pos2 = Random.Range (-10.0f, 10.0f);
					//double pos1 = player.transform.position;
					//double pos2 = Random.Range (-10.0f, 10.0f);
					//double playerposition = this.transform.position;
					//float xPos = (float)pos1;
					//float zPos = (float)pos2;
					//float playerpos2 = (float) playerposition;
					//Instantiate(newPreFab,new Vector3(xPos,0.3f,zPos),Quaternion.identity);
					Instantiate(newPreFab,gameObject.transform.position,Quaternion.identity);
					

				}
			}
	/*
		// destroy
		private foodAppear2 fa;

		void Awake(){
			fa = GameObject.FindObjectOfType<foodAppear2>();
		}


		float time = fa.timeForNewFood;
		float time2 = Time.time;
		*/

	}
	/*
	// destroy
	private foodAppear2 fa;
	public float initialTimeCheck;
	void Awake(){
		fa = GameObject.FindObjectOfType<foodAppear2>();
	}


	public float timeforNewFood;

	float time2 = Time.time;
	float time1 = 0.0f;

	void Update(){
		if (time2 > initialTimeCheck) {
			if (time2 - time1> timeforNewFood) {
				if (touched == true) {
					
					Destroy (gameObject);


				}
			}		
		}
	}*/
		
		
		//if (touched == true) {
			// Instantiate at position (0, 0, 0) and zero rotation.
		//	Instantiate(newPrefab, new Vector3(0, 0, 0), Quaternion.identity);
		//}


}