using UnityEngine;
[CreateAssetMenu(fileName = "NewRotationChange", menuName = "Scriptable Objects/SORotationChange")]
public class SORotationChange : ScriptableObject
{
	public SOVector3 rotation;

	public void Call(GameObject gameObject)
	{
		gameObject.transform.Rotate(rotation.X.Value, rotation.Y.Value, rotation.Z.Value);
	}

}
