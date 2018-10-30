using UnityEngine;

public class ItemSpawn : MonoBehaviour
{
    public SOSpawnList ItemSpawnList;
    public SOInt ThrowDirection;
    private SOSpawn spawnPoint;
    
    public void Start()
    {
        
        spawnPoint = ItemSpawnList.SpawnList[ThrowDirection.Value - 1];
        
        //Transform GameObject to that position, movement happens automatically
        gameObject.transform.position = new Vector3(spawnPoint.ObjectPosition.X.Value, spawnPoint.ObjectPosition.Y.Value, spawnPoint.ObjectPosition.Z.Value);
        gameObject.transform.Rotate(spawnPoint.ObjectRotation.X.Value, spawnPoint.ObjectRotation.Y.Value, spawnPoint.ObjectRotation.Z.Value);        
    }
}
