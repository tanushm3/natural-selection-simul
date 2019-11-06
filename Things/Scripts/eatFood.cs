using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eatFood : MonoBehaviour {
	public GameObject food;
	public GameObject player;
	public Vector3 foodPos;
	public Vector3 playerPos;

	// Use this for initialization
	void Start () {
		float myX = food.transform.position.x;
		float myY = food.transform.position.y;
		float myZ = food.transform.position.z;
		foodPos = new Vector3 (myX, myY, myZ);

		float X = player.transform.position.x;
		float Y = player.transform.position.y;
		float Z = player.transform.position.z;
		playerPos = new Vector3 (X, Y, Z);

		if (playerPos == foodPos){
			Destroy (food);
		}


	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
