using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public SOSpawnList ThisSpawnList;
    private SOSpawn spawnPoint;
    
    public void Start()
    {
        
        //Select a random SpawnPoint from the list
        spawnPoint = ThisSpawnList.SpawnList[Random.Range(0, ThisSpawnList.SpawnList.Count)];
        
        //Transform GameObject to that position, movement happens automatically
        gameObject.transform.position = new Vector3(spawnPoint.ObjectPosition.X.Value, spawnPoint.ObjectPosition.Y.Value, spawnPoint.ObjectPosition.Z.Value);
        gameObject.transform.Rotate(spawnPoint.ObjectRotation.X.Value, spawnPoint.ObjectRotation.Y.Value, spawnPoint.ObjectRotation.Z.Value);        
    }
}
