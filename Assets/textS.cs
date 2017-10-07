using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class textS : MonoBehaviour {

	public Text texti;
	public collisionScript cScript;



	// Use this for initialization
	void Start () {

		cScript =  GameObject.Find("collisonScript").GetComponent<collisionScript>();
		
	}
	
	// Update is called once per frame
	void Update () {

	//texti.text= "Total Score :" + cScript.myint;
		
	}
}
