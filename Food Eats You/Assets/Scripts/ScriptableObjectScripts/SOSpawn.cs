using UnityEngine;
[CreateAssetMenu(fileName = "NewSpawn", menuName = "Scriptable Objects/SOSpawn")]
public class SOSpawn : ScriptableObject
{
    public SOVector3 EnemyPosition;
    public SOVector3 EnemyRotation;
}
