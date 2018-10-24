using UnityEngine;

[CreateAssetMenu(fileName = "DebugObject")]
public class DebugObject : ScriptableObject {

    public void Call(string s)
    {
        Debug.Log(s);
    }

}
