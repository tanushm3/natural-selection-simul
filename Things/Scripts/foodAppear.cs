using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class foodAppear : MonoBehaviour {
	public int numOfFood;
	public GameObject food;

	void Start() {
		for (int i = 0; i < numOfFood; i++) {
			double pos1 = Random.Range (-10.0f, 10.0f);
			double pos2 = Random.Range (-10.0f, 10.0f);
			float xPos = (float)pos1;
			float zPos = (float)pos2;
			Instantiate(food,new Vector3(xPos,0.3f,zPos),Quaternion.identity);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
