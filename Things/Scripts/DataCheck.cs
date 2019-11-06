using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataCheck : MonoBehaviour {

	public int thingyCount;
	public float time2;
	public float deltaTimeVar;
	float time1 = 0.0f;
	//public float[] timeArray;

	List<List<float>> list = new List<List<float>>();


	List<List<string>> PopulationList = new List<List<string>>();


	// Update is called once per frame
	void Update () {
		GameObject[] thingyToFind = GameObject.FindGameObjectsWithTag ("Player");
	
		thingyCount = thingyToFind.Length;
		time2 = Time.time;
		if (time2 - time1 >= deltaTimeVar) {

			List<string> pop = new List<string>();
			for(int i = 0; i < thingyCount; i++){
				string newname = thingyToFind[i].name;
				pop.Add(newname);
			}

			PopulationList.Add(pop);
			List<float> sublist = new List<float>();
			time1 = time2;
			float vari = (float)thingyCount;
			sublist.Add (time2);
			sublist.Add (vari);

			list.Add(sublist);

		}
	}
}
