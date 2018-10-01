using UnityEngine;
using UnityEngine.Events;

public class TriggerID : MonoBehaviour
{

    public NameID Id;
    public UnityEvent OnMatch;
    
    private void OnTriggerEnter(Collider obj)
    {
        if (Id == obj.GetComponent<ObjectID>().Id)
        {
            OnMatch.Invoke();
            print("Match");
        }
    }
    
}
