using UnityEngine;
using UnityEngine.Events;

public class EventStart : MonoBehaviour
{
	public UnityEvent Event;

	private void Start()
	{
		Event.Invoke();
	}
}
