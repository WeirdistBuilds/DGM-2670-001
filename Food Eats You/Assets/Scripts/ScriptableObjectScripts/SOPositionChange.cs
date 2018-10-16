using UnityEngine;
[CreateAssetMenu(fileName = "NewPositionChange", menuName = "Scriptable Objects/SOPositionChange")]
public class SOPositionChange : ScriptableObject
{
    public SOVector3 position;

    public void Call(GameObject gameObject)
    {
        gameObject.transform.position = new Vector3(position.X.Value, position.Y.Value, position.Z.Value);
    }

}
