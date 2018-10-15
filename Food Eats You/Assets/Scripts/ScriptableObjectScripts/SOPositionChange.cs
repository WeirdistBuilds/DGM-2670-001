using UnityEngine;
[CreateAssetMenu(fileName = "NewPositionChange", menuName = "Scriptable Objects/SOPositionChange")]
public class SOPositionChange : ScriptableObject
{
    public SOFloat X, Y, Z;
    private SOVector3 position;
    private Vector3 Rotation;

    public void Spawn(GameObject gameObject)
    {
        position = new Vector3(X.Value, Y.Value, Z.Value);
        gameObject.transform.position = position;
    }

}
