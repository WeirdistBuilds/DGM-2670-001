using UnityEngine;
using UnityEngine.Events;

public class EventUpdate : MonoBehaviour
{
    public UnityEvent Event;

    private void Update()
    {
        Event.Invoke();
    }
}