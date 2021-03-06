﻿using UnityEngine;
using System.Collections;
using AssemblyCSharp;

public class CCloud : MonoBehaviour {
	public float lifeTime;
	float birthTime;
	float deltaTime;
	bool alive;
	public GameObject rainDrop;
	// Use this for initialization
	void Start () {
		alive=true;
		birthTime=ToolManager.gameTime;
		Instantiate(rainDrop,this.transform.position+new Vector3(0,-1,0),Quaternion.Euler(0,180,0));
		//Destroy (gameObject, 1.0f);  
	}
	
	// Update is called once per frame
	void Update () {
		if(!ToolManager.alive){
			alive=false;
			return;	
		}
		if(alive)
			if(lifeTime<ToolManager.gameTime-birthTime)
				alive=false;
		if(!alive)
			if(ToolManager.alive)
				Destroy(gameObject);
		alive=ToolManager.alive;
	}
}
