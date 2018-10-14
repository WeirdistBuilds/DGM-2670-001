using UnityEngine;

[CreateAssetMenu(fileName = "NewInstance", menuName = "Scriptable Objects/SOInstance")]
public class SOInstance : ScriptableObject
{
	public void Call(GameObject instance)
	{
		Instantiate(instance);
	}
}
