using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "NewSpawnList", menuName = "Scriptable Objects/SOSpawnList")]
public class SOSpawnList : ScriptableObject
{
    public List<SOSpawn> SpawnList;
}
