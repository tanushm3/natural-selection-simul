using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class R1 : MonoBehaviour {
	

		public int touched = 1;
		public float t2;
		//public float deltaTimeVar;
		float t1 = 0.0f;



	void Update () {
		t2 = Time.time;
		if (t2 - t1 >= 5.0f) {
			touched = 1;
			t1 = t2;
		}
	}


}
