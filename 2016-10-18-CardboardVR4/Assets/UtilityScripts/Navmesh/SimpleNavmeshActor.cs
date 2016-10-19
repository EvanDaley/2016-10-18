using UnityEngine;
using System.Collections;

public class SimpleNavmeshActor : MonoBehaviour {

	public Transform targetObject;

	private NavMeshAgent navMeshAgent;

	void Start () 
	{
		navMeshAgent = GetComponent<NavMeshAgent> ();

		navMeshAgent.SetDestination (targetObject.position);
	}
	
	void Update () 
	{
		
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.name == "goal1")
		{
			navMeshAgent.SetDestination(GameObject.Find ("goal2").transform.position);

		} else if (other.gameObject.name == "goal2")
		{
			navMeshAgent.SetDestination(GameObject.Find ("goal3").transform.position);
		}else if (other.gameObject.name == "goal3")
		{
			navMeshAgent.SetDestination(GameObject.Find ("goal4").transform.position);
		}else if (other.gameObject.name == "goal4")
		{
			navMeshAgent.SetDestination(GameObject.Find ("goal1").transform.position);
		}
	}
}
