using UnityEngine;
[CreateAssetMenu(fileName = "NewSpawn", menuName = "Scriptable Objects/SOSpawn")]
public class SOSpawn : ScriptableObject
{
    public SOVector3 ObjectPosition;
    public SOVector3 ObjectRotation;
}
