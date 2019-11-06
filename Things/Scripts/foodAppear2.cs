using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class foodAppear2 : MonoBehaviour {
	public int numOfFood;
	public GameObject food;

	public float timeForNewFood;
	bool inCoRoutine;


	void makeFood(){
		for (int i = 0; i < numOfFood; i++) {
			double pos1 = Random.Range (-10.0f, 10.0f);
			double pos2 = Random.Range (-10.0f, 10.0f);
			float xPos = (float)pos1;
			float zPos = (float)pos2;
			Instantiate (food, new Vector3 (xPos, 0.3f, zPos), Quaternion.identity);
		}
	}

	/*
	Vector3 getNewRandomPosition()
	{
		float x = Random.Range (-20, 20);
		float z = Random.Range (-20, 20);
		Vector3 pos = new Vector3 (x,-5.0f,z);
		return pos;
	}*/
	IEnumerator DoSomething(){

		inCoRoutine = true;
		yield return new WaitForSeconds (timeForNewFood);
		//GetNewPath ();
		makeFood();
		inCoRoutine = false;

	}

	/*void GetNewPath()
	{
		navMeshAgent.SetDestination (getNewRandomPosition());
	}*/

	// Update is called once per frame
	void Update () {
		if (!inCoRoutine) {
			StartCoroutine (DoSomething ());
		}
	}




}



