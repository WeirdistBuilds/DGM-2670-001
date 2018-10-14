using UnityEngine;
using UnityEngine.Events;

public class EventTriggerExit : MonoBehaviour
{
	public UnityEvent Event;

	private void OnTriggerExit(Collider other)
	{
		Event.Invoke();
	}
}
