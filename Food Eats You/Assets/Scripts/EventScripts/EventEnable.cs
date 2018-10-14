using UnityEngine;
using UnityEngine.Events;

public class EventEnable : MonoBehaviour
{
	public UnityEvent Event;

	private void OnEnable()
	{
		Event.Invoke();
	}
}
