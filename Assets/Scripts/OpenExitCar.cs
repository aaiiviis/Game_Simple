﻿using UnityEngine;
using System.Collections;

namespace UnityStandardAssets.Vehicles.Car
{

public class OpenExitCar : MonoBehaviour {
	
	public bool Player;
	public GameObject PoliceMan;
	public bool inCar;
	public GameObject CarCamera;
	public GameObject PlayerCamera;
	public GameObject Exit;
	public GameObject Camera;
	
	void Start (){
	   gameObject.GetComponent<CarController>().enabled = false;
	   gameObject.GetComponent<CarUserControl>().enabled = false;
	   gameObject.GetComponent<CarAudio>().enabled = false;
	   CarCamera.SetActive (false);
	   PlayerCamera.SetActive (true);
	   
   }
	

void OnTriggerEnter(Collider other){
	if(other.tag=="Player")
	{
		Player=true;
			
		}
}
void OnTriggerExit(Collider other){
	if(other.tag=="Player")
	{
		Player=false;
	}
}
void Update (){
	if (Player==true){
   if (Input.GetKeyDown(KeyCode.F)){
	   PoliceMan.SetActive (false);
	   inCar=true;
	   gameObject.GetComponent<CarController>().enabled = true;
	   gameObject.GetComponent<CarUserControl>().enabled = true;
	   gameObject.GetComponent<CarAudio>().enabled = true;
	   CarCamera.SetActive (true);
	   PlayerCamera.SetActive (false);
	   Camera. SetActive (false);
	
	   
   }
	   
}
if (inCar==true){
	if (Input.GetKeyDown(KeyCode.E)){
		PoliceMan.SetActive (true);
		PoliceMan.transform.position=Exit.transform.position;
		inCar=false;
		gameObject.GetComponent<CarController>().enabled = false;
	   gameObject.GetComponent<CarUserControl>().enabled = false;
	   gameObject.GetComponent<CarAudio>().enabled = false;
	   CarCamera.SetActive (false);
	   PlayerCamera.SetActive (true);
	   Camera.SetActive (true);
	}
}
}
}

}
		

 
