using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindPlane : MonoBehaviour
{

	public GameObject moose;
	private GameObject planex;

	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
	
		if (planex == null) {
			planex = GameObject.Find ("Plane");
			Vector3 pos = planex.transform.position;
			GameObject Moose;
			Moose = Instantiate (moose, pos, Quaternion.identity) as GameObject;
			Moose.SetActive (true);
		}
	}
}
