using UnityEngine;
using UnityEngine.Events;

public class MatchID : MonoBehaviour
{
    public NameID ID;
    public UnityEvent OnMatch;
    public UnityEvent NoMatch;
    //public BoolData Matched;
    

    private void OnTriggerEnter(Collider other)
    {
        var id = other.GetComponent<ObjectID>().ID;
        CompareMatch(id);
    }
    
    public void CompareMatch(NameID match)
    {
        if (match == ID)
        {
        //  Matched.Value = true;
            OnMatch.Invoke();
        }
        else
        {
            NoMatch.Invoke();
        }
    }
    
}