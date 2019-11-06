using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObjects : MonoBehaviour {


	private foodAppear2 fa;

	void Awake(){
		fa = GameObject.FindObjectOfType<foodAppear2>();
	}


	//float time = fa.timeForNewFood;
	float time2 = Time.time;


	void Update(){
		
	}
}
