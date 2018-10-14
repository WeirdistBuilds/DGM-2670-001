using UnityEngine;
using UnityEngine.Events;

public class EventMouseDown : MonoBehaviour
{
	public UnityEvent Event;

	private void OnMouseDown()
	{
		Event.Invoke();
	}
}
