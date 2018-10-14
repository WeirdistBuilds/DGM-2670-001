using UnityEngine;
using UnityEngine.Events;

public class EventTriggerEnter : MonoBehaviour
{
	public UnityEvent Event;

	private void OnTriggerEnter(Collider other)
	{
		Event.Invoke();
	}
}
