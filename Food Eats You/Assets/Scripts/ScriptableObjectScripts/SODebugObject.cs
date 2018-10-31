using UnityEngine;

[CreateAssetMenu(fileName = "NewDebugObject", menuName = "Scriptable Objects/SODebugObject")]
public class SODebugObject : ScriptableObject {

    public void Call(string s)
    {
        Debug.Log(s);
    }

}
