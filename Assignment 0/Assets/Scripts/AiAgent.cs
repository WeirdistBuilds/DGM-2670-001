using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class AiAgent : MonoBehaviour
{
	private NavMeshAgent agent;
	public Transform PlayerLocation;
	public Transform BackWall;
	private Transform finalDestination;
	
	private void Start ()
	{
		agent = GetComponent<NavMeshAgent>();
		finalDestination = PlayerLocation;
	}

	private void OnTriggerEnter(Collider obj)
	{
		if (obj.transform == BackWall)
			finalDestination = PlayerLocation;
		else
			finalDestination = BackWall;
	}
	
	private void Update()
	{
		agent.destination = finalDestination.position;
	}
}
