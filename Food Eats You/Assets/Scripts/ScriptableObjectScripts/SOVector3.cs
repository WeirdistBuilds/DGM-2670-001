using UnityEngine;
[CreateAssetMenu(fileName = "NewVector3", menuName = "Scriptable Objects/SOVector3")]
public class SOVector3 : ScriptableObject
{
	public SOFloat X, Y, Z;
	public Vector3 Vector3
	{
		set { new Vector3(X.Value, Y.Value, Z.Value); }
		get { return Vector3; }
	}
}
