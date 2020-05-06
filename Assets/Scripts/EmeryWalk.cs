using UnityEngine;
using System.Collections;

public class EmeryWalk : MonoBehaviour {

public GameObject Emery;
public float timer;
public bool yes;
public float newtimer;


void Start () {
	newtimer=timer;

}

void OnTriggerEnter(Collider other){
	if (other.tag == "Player") {
		Emery.GetComponent<UnityEngine.AI.NavMeshAgent>().enabled = true;
		Emery.GetComponent<Animator>().SetTrigger ("Walk");
		
		
	}
}
void OnTriggerExit(Collider other){
	if(other.tag == "Player") {
	yes=true;
	}
		
	
	
}
void Update () {
	if(yes==true){
		timer -= Time.deltaTime;  
	}
	if(timer < 0){
		Emery.GetComponent<UnityEngine.AI.NavMeshAgent>().enabled = false;
		yes=false;
		timer=newtimer;
		Emery.GetComponent<Animator>().SetTrigger ("Idle");
	}
		
}
}



	