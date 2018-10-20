using UnityEngine;

public class ItemThrow : ScriptableObject
{
    public SOSpawnList ItemSpawnList;
    public SOInt ThrowDirection;
    private SOSpawn spawnPoint;
    
    public void Invoke()
    {
        
        spawnPoint = ItemSpawnList.SpawnList[Random.Range(0, ItemSpawnList.SpawnList.Count)];
        
        //Transform GameObject to that position, movement happens automatically
        gameObject.transform.position = new Vector3(spawnPoint.EnemyPosition.X.Value, spawnPoint.EnemyPosition.Y.Value, spawnPoint.EnemyPosition.Z.Value);
        gameObject.transform.Rotate(spawnPoint.EnemyRotation.X.Value, spawnPoint.EnemyRotation.Y.Value, spawnPoint.EnemyRotation.Z.Value);        
    }
}
