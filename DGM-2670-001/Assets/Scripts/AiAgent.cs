using UnityEditor;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class AiAgent : MonoBehaviour
{
	private NavMeshAgent agent;
	public Transform Destination;
	public Transform PostPoint;
	private Transform finalDestination;
	public FloatData Speed;
	
	private void Start ()
	{
		agent.speed = Speed.Value;
		agent = GetComponent<NavMeshAgent>();
		finalDestination = transform;
	}

	private void OnTriggerEnter(Collider obj)
	{
		if (obj.transform == Destination)
			finalDestination = Destination;
	}
	
	private void OnTriggerExit(Collider obj)
	{
		finalDestination = PostPoint;
	}

	private void Update()
	{
		agent.destination = finalDestination.position;
	}
}
