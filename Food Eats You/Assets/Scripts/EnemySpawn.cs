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
        gameObject.transform.position = new Vector3(spawnPoint.EnemyPosition.X.Value, spawnPoint.EnemyPosition.Y.Value, spawnPoint.EnemyPosition.Z.Value);
        gameObject.transform.Rotate(spawnPoint.EnemyRotation.X.Value, spawnPoint.EnemyRotation.Y.Value, spawnPoint.EnemyRotation.Z.Value);        
    }
}
