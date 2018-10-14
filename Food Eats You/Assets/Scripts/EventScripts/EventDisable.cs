using UnityEngine;
using UnityEngine.Events;

public class EventDisable : MonoBehaviour
{
	public UnityEvent Event;

	private void OnDisable()
	{
		Event.Invoke();
	}
}
