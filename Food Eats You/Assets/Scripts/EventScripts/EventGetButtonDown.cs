using UnityEngine;
using UnityEngine.Events;

public class EventGetButtonDown : MonoBehaviour
{
	public UnityEvent Event;
	public string InputName; 

	void Update() 
	{
		if (Input.GetButtonDown(InputName))
		{
			Event.Invoke();
		}
	}
}
