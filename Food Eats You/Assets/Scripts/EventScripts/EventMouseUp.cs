using UnityEngine;
using UnityEngine.Events;

public class EventMouseUp : MonoBehaviour
{
	public UnityEvent Event;

	private void OnMouseUp()
	{
		Event.Invoke();
	}
}
