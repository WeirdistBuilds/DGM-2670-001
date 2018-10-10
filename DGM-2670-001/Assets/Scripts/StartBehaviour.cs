using UnityEngine;
using UnityEngine.Events;

public class StartBehaviour: MonoBehaviour
{
    public UnityEvent Event;

    private void OnMouseDown()
    {
        Event.Invoke();
    }
        

}
