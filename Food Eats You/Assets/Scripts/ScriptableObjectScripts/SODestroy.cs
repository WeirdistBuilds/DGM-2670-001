using UnityEngine;

[CreateAssetMenu(fileName = "NewDestroy", menuName = "Scriptable Objects/SODestroy")]
public class SODestroy : ScriptableObject
{

	public void Call()
	{
		Destroy(this);
	}
	
}
