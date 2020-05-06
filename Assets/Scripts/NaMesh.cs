using UnityEngine;
using System.Collections;

public class NaMesh : MonoBehaviour {

public Transform target;
UnityEngine.AI.NavMeshAgent Agent;

void Start (){
	Agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
	
}


void Update(){
	Agent.SetDestination(target.position);
}
}